using UnityEngine;

public class CreadorGameObjects : MonoBehaviour
{
    [SerializeField]
    GameObject[] objetoQueVoyACrear;
    [SerializeField]
    int cantidadDeObjetos = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Random.Range(-3f, 3f));
        //Crear 5 objetos en posiciones aleatorias
        for (int i = 0; i < cantidadDeObjetos; i++)
        {
            float posicionX = Random.Range(-7f, 7f);
            float posicionY = Random.Range(-2f, 4f);
            float posicionZ = Random.Range(-1f, 10f);
            int numAleatorio = Random.Range(0, objetoQueVoyACrear.Length);
            Instantiate(objetoQueVoyACrear[numAleatorio], new Vector3(posicionX, posicionY, posicionZ), Quaternion.identity);
        }

       

    }

    
}
