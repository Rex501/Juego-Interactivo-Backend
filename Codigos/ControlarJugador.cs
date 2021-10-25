using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlarJugador : MonoBehaviour
{
    //variable para saltar
    public float alturasalto;

    //variable para la velocidad del movimiento
    public float velocidadMovimiento;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //MOVIMIENTO DEL PERSONAJE

        //Saltar, usamos la barra espaciadora para saltar
        if (Input.GetKeyDown(KeyCode.Space))
        {
           rb.velocity = new Vector2(rb.velocity.x, alturasalto);
        }

        //Mover a la derecha, usamos la tecla D para movernos a la derecha.
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(velocidadMovimiento, rb.velocity.y);

        }

        //Mover a la izquierda, usamos la tecla A para movernos a la izquierda.
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-velocidadMovimiento, rb.velocity.y);
        }
    }
}