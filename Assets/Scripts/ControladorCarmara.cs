using UnityEngine;

public class ControladorCarmara : MonoBehaviour
{
    // Velocidad, determina la velocidad a la que se mueve la cámara
    public float velocidad = 300;
    public float rotacion = 300;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Si presiono la tecla W
        if (Input.GetKey(KeyCode.W)) // comprueba qué tecla se presiona
        {
            Vector3 movimientoEjeZ = new Vector3(0, 0, velocidad); // Crea una variable con parámetros de entrada de tipo Vector3
            transform.Translate(movimientoEjeZ * Time.deltaTime); // utiliza el método Transform.Translate (para desplazar la cam)
        }
        // Tecla S
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 movimientoEjeZ = new Vector3(0, 0, -velocidad);
            transform.Translate(movimientoEjeZ * Time.deltaTime);
        }
        // Tecla A
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 movimientoEjeX = new Vector3(-velocidad, 0, 0);
            transform.Translate(movimientoEjeX * Time.deltaTime);
        }
        // Tecla D
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 movimientoEjeX = new Vector3(velocidad, 0, 0);
            transform.Translate(movimientoEjeX * Time.deltaTime);
        }
        // Flecha arriba
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 movimientoEjeY = new Vector3( 0, velocidad, 0);
            transform.Translate(movimientoEjeY * Time.deltaTime);
        }
        // Flecha abajo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 movimientoEjeY = new Vector3( 0, -velocidad, 0);
            transform.Translate(movimientoEjeY * Time.deltaTime);
        }
         // Flecha Izquierda (rota a la izq)
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 rotacionEjeY = new Vector3( 0, -rotacion, 0);
            transform.Rotate(rotacionEjeY * Time.deltaTime);  // utiliza el método Transform.Rotate (para girar la cam a izq/der)
        }
        // Flecha derecha (rota a la izq)
         if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 rotacionEjeY = new Vector3( 0, rotacion, 0);
            transform.Rotate(rotacionEjeY * Time.deltaTime);
        }
            
        
    }
}
