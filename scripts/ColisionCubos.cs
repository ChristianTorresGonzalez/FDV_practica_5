using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionCubos : MonoBehaviour
{
    public GameObject jugador;

    void Start()
    {
        jugador = GameObject.FindWithTag("Jugador");
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == jugador.tag)
        {
            Vector3 direction = (transform.position - jugador.transform.position).normalized;
            GetComponent<Rigidbody>().AddForce(direction * jugador.GetComponent<PoderJugador>().GetPoder());
        }
    }
}
