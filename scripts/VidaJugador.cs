using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJugador : MonoBehaviour
{
    private int vidas;
    public CanvasVidaJugador healthBar;

    private void Start()
    {
        vidas = 5;
        
        comprobarModoJuego();

        healthBar.SetMaxHealth(vidas);
    }

    public void VidaModoTurbo()
    {
        vidas--;
    }

    public void RestarVida()
    {
        if (vidas > 1)
        {
            vidas--;

            healthBar.SetHealth(vidas);
        } else
        {
            healthBar.SetHealth(0);
            SceneManager.LoadScene("Final");
        }
    }

    void comprobarModoJuego()
    {
        if (PlayerPrefs.GetInt("juegoTurbo") == 1)
        {
            VidaModoTurbo();
        }
    }
}