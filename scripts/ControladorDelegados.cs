using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDelegados : MonoBehaviour
{
    public delegate void llaveRecolectada(string llave, bool opcion);

    public event llaveRecolectada EventoLlavePuerta;

    public void LanzarLlavePuerta(string llave, bool opcion)
    {
        if (EventoLlavePuerta != null)
        {
            EventoLlavePuerta(llave, opcion);
        }
    }
}
