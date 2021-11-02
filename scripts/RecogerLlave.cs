using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerLlave : MonoBehaviour
{
    public ControladorDelegados controlador;

    public GameObject jugador;

    void Start()
    {
        jugador = GameObject.FindWithTag("Jugador");
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == jugador.tag)
        {
            if (this.gameObject.tag == "llaveGlobal")
            { 
                controlador.LanzarLlavePuerta(this.gameObject.name, true);
            } else
            {
                controlador.LanzarLlavePuerta(this.gameObject.name, false);
            }

            GameObject.Destroy(this.gameObject);
        }
    }
}
