using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionEsferas : MonoBehaviour
{
    GameObject jugador;
    public Vector3 escala;

    void Start()
    {
        escala = new Vector3(0.25f, 0.25f, 0.25f);
        jugador = GameObject.FindWithTag("Jugador");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == jugador.tag)
        {
            jugador.GetComponent<PoderJugador>().AumentarPoder();
            this.GetComponent<CambiarColor>().CambiarColorEsfera();
            
            transform.localScale -= escala;
        }
    }
}
