using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;
    public float velocidad = 5f;

    private void Update()
    {
        movimientoEjeX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        movimientoEjeZ = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        transform.Translate(movimientoEjeX, 0, movimientoEjeZ);
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(horizontal, 0, vertical);

        if (direccion.magnitude >= 0f)
        {
            direccion=direccion.normalized;
        }

}


}
