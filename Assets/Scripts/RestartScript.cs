using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public void RestartButton()
    {
        Time.timeScale = 1;
        GameManager.health = 3;
        ScoreManager.scoreCount = 0;
        SceneManager.LoadScene(2);
    }

    public static void RewardButton()
    {
        Time.timeScale = 1;
        GameManager.health = 3;
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        GameManager.health = 3;
        ScoreManager.scoreCount = 0;
        SceneManager.LoadScene(0);
    }

  
}
