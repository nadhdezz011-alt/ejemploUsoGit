using Unity.VisualScripting;
using UnityEngine;

public class ContadorDeEspacios : MonoBehaviour
{
    int vecesPulsado = 0;
    Rigidbody rb;
    public float fuerza = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
     void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            rb.AddForce(Vector3.up * fuerza, ForceMode.Impulse);

            vecesPulsado = vecesPulsado + 1;
            Debug.Log(vecesPulsado);

            if (vecesPulsado == 5)
            {
                Debug.Log("Pulsado 5 veces");
                vecesPulsado = 0;
            } else
            {
                Debug.Log("Veces pulsado = " + vecesPulsado);
        
            }
        }
       
        
    
 
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entra en colisión");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Sigue en Colision");
    }

    
    
        
    
}



