using UnityEngine;

public class InterruptorDeObjetos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambiarEstadoDeObjeto()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

}
