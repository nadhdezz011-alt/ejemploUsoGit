using System;
using TMPro;
using UnityEngine;
public class LeanTweenEjemplo : MonoBehaviour
{
    [SerializeField]
    GameObject objeto;
    [SerializeField]
    float animationTime = 0.75f;
    [SerializeField]
    Vector3 newPosition = new Vector3(0.0f, 4.10f, 0.0f);
    [SerializeField]
    LeanTweenType curva;
    Vector3 originalScale;

    [SerializeField]
    TextMeshProUGUI etiquetaTexto;
    private void Start()
    {
        originalScale = objeto.transform.localScale;
        etiquetaTexto.text = "Agrandar";
    }
    public void AccionBoton()
    {
        if (LeanTween.isTweening(objeto) == false)
        {

            if (objeto.transform.localScale == originalScale)
            {
                LeanTween.scale(objeto, originalScale * 3f, animationTime).setEase(curva);
                etiquetaTexto.text = "Encoger";
            }  
            else
            {
               LeanTween.scale(objeto, originalScale, animationTime).setEase(curva);
                etiquetaTexto.text = "Agrandar";
            }
        }
       
    }
   
}
