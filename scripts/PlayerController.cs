using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad_movimiento;
    public float velocidad_rotacion;

    public float ejeX;
    public float ejeY;
    public float ejeZ;

    public float poder;

    void Start()
    {
        velocidad_movimiento = 0.01f;
        velocidad_rotacion = 0.5f;

        poder = 1000f;
    }

    void Update()
    {
        ejeX = gameObject.transform.position.x;
        ejeY = gameObject.transform.position.y;
        ejeZ = gameObject.transform.position.z;

        if (Input.GetKey("w"))
        {
            transform.position = new Vector3(ejeX + (1 * velocidad_movimiento), ejeY, ejeZ);
        }

        if (Input.GetKey("s"))
        {
            transform.position = new Vector3(ejeX - (1 * velocidad_movimiento), ejeY, ejeZ);
        }

        if (Input.GetKey("a"))
        {
            transform.position = new Vector3(ejeX, ejeY, ejeZ + (1 * velocidad_movimiento));
        }

        if (Input.GetKey("d"))
        {
            transform.position = new Vector3(ejeX, ejeY, ejeZ - (1 * velocidad_movimiento));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0f, 1 * velocidad_rotacion, 0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0f, -(1 * velocidad_rotacion), 0f);
        }
    }

    public float GetPoder()
    {
        return poder;
    }
}
