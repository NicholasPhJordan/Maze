using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    //Creates a function for the restart button that moves the game back one scene to the game scene
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //creates function to the quit button that closes the application
    public void QuitGame()
    {
        Application.Quit();
    }
}
