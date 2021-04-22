using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenuUi;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
                Resume();
            else
                Pause();
        }
    }

    //creates function to the resume button that unpauses the game and clears the pause menu
    public void Resume()
    {
        pauseMenuUi.SetActive(false); //deactivates the pauseMenuUI
        Time.timeScale = 1f; //continues the game
        gamePaused = false;
    }

    //Pauses the game and shows the pause menu
    void Pause()
    {
        pauseMenuUi.SetActive(true); //activates the pauseMenuUI
        Time.timeScale = 0f; //stops the game time 
        gamePaused = true;
    }

    //creates function to the quit button that closes the application
    public void QuitGame()
    {
        Application.Quit();
    }
}
