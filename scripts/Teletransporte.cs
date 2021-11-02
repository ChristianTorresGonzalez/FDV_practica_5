using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransporte : MonoBehaviour
{
    GameObject jugador;
    GameObject teleportIzquierda;
    GameObject teleportDerecha;
    GameObject camara;

    private void Start()
    {
        camara = GameObject.FindWithTag("MainCamera");
        jugador = GameObject.FindWithTag("Jugador");
        teleportIzquierda = GameObject.FindWithTag("TeletransporteIzquierda");
        teleportDerecha = GameObject.FindWithTag("TeletransporteDerecha");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == jugador.tag)
        {
            if (this.tag == teleportIzquierda.tag)
            {
                jugador.transform.position = GameObject.FindWithTag("spawn1").transform.position + new Vector3(0.0f, 1f, 0.0f);
                camara.transform.position = GameObject.FindWithTag("posicioncamara2").transform.position;
            } else if (this.tag == teleportDerecha.tag)
            {
                jugador.transform.position = GameObject.FindWithTag("spawn2").transform.position + new Vector3(0.0f, 1f, 0.0f);
                camara.transform.position = GameObject.FindWithTag("posicioncamara1").transform.position;
            }
        }
    }
}
