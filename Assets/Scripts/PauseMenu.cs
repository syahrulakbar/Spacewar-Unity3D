using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;

    public void Pause()
    {
        if(GameManager.health >0)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void ResetButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        GameManager.health = 3;
        ScoreManager.scoreCount = 0;

        SceneManager.LoadScene(2);

    }

    public void MainMenu()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        GameManager.health = 3;
        ScoreManager.scoreCount = 0;
        SceneManager.LoadScene(0);
    }



}
