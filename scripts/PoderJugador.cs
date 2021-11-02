using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderJugador : MonoBehaviour
{
    private float poder;

    void Start()
    {
        poder = 500f;
    }

    public void AumentarPoder()
    {
        poder += 100f;
    }

    public float GetPoder()
    {
        return poder;
    }
}
