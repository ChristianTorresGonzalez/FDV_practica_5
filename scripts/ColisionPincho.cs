using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPincho : MonoBehaviour
{
    GameObject jugador;

    void Start()
    {
        jugador = GameObject.FindWithTag("Jugador");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == jugador.tag)
        {
            jugador.GetComponent<VidaJugador>().RestarVida();
        }
    }
}
