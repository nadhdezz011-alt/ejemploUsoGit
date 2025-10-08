using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContadorEspacios : MonoBehaviour
{
    [Header("Física")]
    public Rigidbody rb;
    public float fuerza = 5f;

    [Header("UI")]
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI resultText;
    public Button restartButton;

    [Header("Configuración del juego")]
    public float duracion = 10f; // duración en segundos

    private int vecesPulsado = 0;
    private float tiempoRestante;
    private bool juegoActivo = true;

    void Start()
    {
        if (rb == null) rb = GetComponent<Rigidbody>();
        tiempoRestante = duracion;
        resultText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);

        // Asignar la función del botón
        restartButton.onClick.AddListener(ReiniciarJuego);
    }

    void Update()
    {
        if (!juegoActivo) return;

        // Contar tiempo
        tiempoRestante -= Time.deltaTime;
        timerText.text = "Tiempo: " + tiempoRestante.ToString("F1") + " s";

        // Cuando se acabe el tiempo, detener el juego
        if (tiempoRestante <= 0f)
        {
            tiempoRestante = 0;
            FinalizarJuego();
        }

        // Detectar pulsación de espacio
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * fuerza, ForceMode.Impulse);
            vecesPulsado++;

            Debug.Log("Veces pulsado = " + vecesPulsado);
        }
    }

    void FinalizarJuego()
    {
        juegoActivo = false;
        resultText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        resultText.text = "¡Tiempo terminado!\nHas pulsado " + vecesPulsado + " veces.";
    }

    void ReiniciarJuego()
    {
        // Reiniciar variables
        vecesPulsado = 0;
        tiempoRestante = duracion;
        juegoActivo = true;

        // Resetear UI
        resultText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        timerText.text = "Tiempo: " + tiempoRestante.ToString("F1") + " s";
    }
}

