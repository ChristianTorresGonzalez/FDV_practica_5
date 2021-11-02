using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    Color colorEsfera;
    GameObject[] esferas;
    
    private float restaColor;
    private float umbral;

    void Start()
    {
        restaColor = 0.1f;
        umbral = 0.5f;

        colorEsfera = Color.blue;

        esferas = GameObject.FindGameObjectsWithTag("Esfera");

        foreach (GameObject esfera in esferas)
        {
            esfera.GetComponent<Renderer>().material.color = colorEsfera;
        }
    }

    public void CambiarColorEsfera()
    {
        if (colorEsfera.b >= umbral)
        {
            colorEsfera.b = colorEsfera.b - restaColor;
            this.GetComponent<Renderer>().material.color = colorEsfera;
        } else
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
