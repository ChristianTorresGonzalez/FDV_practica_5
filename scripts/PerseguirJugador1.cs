using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerseguirJugador1 : MonoBehaviour
{
    GameObject jugador;
    float velocidad_movimiento;
    float umbral = 1.5f;
    
    void Start()
    {
        jugador = GameObject.FindWithTag("Jugador2");
        velocidad_movimiento = 5f;
    }

    void Update()
    {
        transform.LookAt(jugador.transform.position);
        
        if ((transform.position - jugador.transform.position).magnitude > umbral)
        {
            transform.Translate(0.0f, 0.0f, velocidad_movimiento * Time.deltaTime);
        }
    }
}
