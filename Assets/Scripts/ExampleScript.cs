using System.Runtime.InteropServices;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public string nombreDelObjeto = "Texto Cualquiera";
    //Variable de tipo entero

    int coints = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(nombreDelObjeto,gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Aumentar en una unidad

        coints += 1;

        //Mostramos
        Debug.Log("En El Update");
        Debug.Log(coints);

        Debug.Log(nombreDelObjeto + " en el update " + coints);

    }
}
