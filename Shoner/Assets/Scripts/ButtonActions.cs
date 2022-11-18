using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Escena juego");
    }

    public void OpenGithub()
    {
        Application.OpenURL("https://github.com/AusiasBM/GTI-4A-Shoner");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
