using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuPrincipal : MonoBehaviour
{
    public void PlayGame()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "Boton Turbo")
        {
            PlayerPrefs.SetInt("juegoTurbo", 1);
            PlayerPrefs.SetInt("juegoNormal", 0);
        } else
        {
            PlayerPrefs.SetInt("juegoTurbo", 0);
            PlayerPrefs.SetInt("juegoNormal", 1);
        }

        SceneManager.LoadScene("Juego");
    }
}
