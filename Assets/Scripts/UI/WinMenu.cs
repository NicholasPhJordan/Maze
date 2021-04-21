using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject winMenuUi;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Win();
        }
    }

    public void Win()
    {
        winMenuUi.SetActive(true);
        Time.timeScale = 0f;
        PauseMenu.gamePaused = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
