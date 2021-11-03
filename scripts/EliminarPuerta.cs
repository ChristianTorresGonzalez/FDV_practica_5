using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class EliminarPuerta : MonoBehaviour
{
    public ControladorDelegados controlador;
    public GameObject jugador;

    void OnEnable()
    {
        controlador.EventoLlavePuerta += eliminarPuerta;
    }

    void OnDeseable()
    {
        controlador.EventoLlavePuerta -= eliminarPuerta;
    }

    private void eliminarPuerta(string llave, bool opcion)
    {
        Debug.Log(opcion);
        if (opcion)
        {
            GameObject[] puertas = GameObject.FindGameObjectsWithTag("Puerta");
            
            foreach (GameObject puerta in puertas)
            {
                GameObject.Destroy(puerta);
            }

            GameObject[] llaves = GameObject.FindGameObjectsWithTag("llave");
            
            foreach (GameObject key in llaves)
            {
                GameObject.Destroy(key);
            }
        } else
        {
            string puerta = filtrarPuerta(llave);
            Debug.Log(puerta);
            GameObject puertaEliminada = GameObject.Find(puerta);
            GameObject.Destroy(puertaEliminada);
        }
    }

    private string filtrarPuerta(string llave)
    {
        string regexp = @"\d+";
        string resultado = Regex.Match(llave, regexp).Value;
        return "Puerta" + resultado;
    }
}
