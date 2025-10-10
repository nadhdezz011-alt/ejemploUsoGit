using UnityEngine;
using TMPro;
public class LeanTweenEjemplo : MonoBehaviour
{
    [SerializeField]
    GameObject objeto;
    [SerializeField]
    float animationtime = 0.75f;
    [SerializeField]
    Vector3 newPosition = new Vector3(0.0f, 4.10f, 0.0f);
    [SerializeField]
    LeanTweenType curva;
   
    public void AccionBoton()
    {
        LeanTween.move(objeto, Vector3.zero, 0.0f);
        LeanTween.move(objeto, newPosition, animationtime).setEase(curva);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
