using Unity.VisualScripting;
using UnityEngine;

public class FuncionesArray : MonoBehaviour
{
    [SerializeField]
    int[] notasAlumnoPrimerTrimestre;

    [SerializeField]
    int[] notasAlumnoSegundoTrimestre;
    //el array sirve`para tener varios datos iguales en una lista
    //se puede acceder de manera directa a cualquier elemento
    //el primer elemento siempre es el numero 0


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MostrarArray(notasAlumnoSegundoTrimestre);
        Debug.Log("Nota más alta del primer trimestre: " + NotaMayor(notasAlumnoSegundoTrimestre));
        //Debug.Log("Nota más alta del segundo trimestre: " + NotaMayor(notasAlumnoSegundoTrimestre));
        Debug.Log("Nota más baja del primer trimestre: " + NotaMenor(notasAlumnoSegundoTrimestre));
        Debug.Log("Nota media del primer trimestre: " + NotaMedia(notasAlumnoSegundoTrimestre));
    }

    /// <summary>
    ///  FUnción que muestra en la consola todos los valores del array
    /// </summary>
    /// <param name="notasAlumno">Array con notas de un alumno en un trimestre</param>

    void MostrarArray(int[] notasAlumno)
    {   
        //Cambiar el Debug.Log(i)para que se muestren las notas que tenemos en el array
        //notasAlumno[indice] me permite verla nota de un examen
        //nunca poner números csumados con i (ej:  for (int i =0; i < 5;i++)

        for (int i =0; i < notasAlumno.Length;i++)
        {
            Debug.Log(notasAlumno[i]);
        }
    }

   int NotaMayor(int[] notasAlumno)
   {
        int notaMasAlta = 0;
        Debug.Log("Inicio la búsqueda de la nota más alta ahora mismo la nota es " + notaMasAlta);
        for (int i = 0; i < notasAlumno.Length; i++)
        {
            Debug.Log(i + "Compruebo " + notasAlumno[i] + ">" + notaMasAlta + "?");
            if (notasAlumno[i] > notaMasAlta)
            {
                Debug.Log("Ahora cambio nota más alta" + notaMasAlta + " por " + notasAlumno[i]);
                notaMasAlta = notasAlumno[i];
            }
        }
        Debug.Log("Temina el bucle con " + notaMasAlta);
        return notaMasAlta;
    }


    int NotaMenor(int[] notasAlumno)
    {
        int notaMasbaja = 10;
       for (int i = 0; i < notasAlumno.Length; i++)
       {
            if (notasAlumno[i] < notaMasbaja)
            {
                notaMasbaja = notasAlumno[i];
            }
       }
        return notaMasbaja;
    }
    float NotaMedia(int[] notasAlumno)
    {
        float sumaNotas = 0;
        for (int i = 0; i < notasAlumno.Length; i++)
        {
            sumaNotas += notasAlumno[i];
        }
        return sumaNotas / notasAlumno.Length;
    }
    





}
