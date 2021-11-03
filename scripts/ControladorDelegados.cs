using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDelegados : MonoBehaviour
{
    public delegate void llaveRecolectada(string llave, bool opcion);
    public delegate void modoJuego();

    public event llaveRecolectada EventoLlavePuerta;
    public event modoJuego EventoModoJuego;

    public void LanzarLlavePuerta(string llave, bool opcion)
    {
        if (EventoLlavePuerta != null)
        {
            EventoLlavePuerta(llave, opcion);
        }
    }

    public void LanzarModoJuego()
    {
        if (EventoModoJuego != null)
        {
            EventoModoJuego();
        }
    }
}
