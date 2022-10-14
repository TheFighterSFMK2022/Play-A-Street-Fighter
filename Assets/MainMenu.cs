using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public void Jugar()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("PlayStreetFighter");
    }
}
