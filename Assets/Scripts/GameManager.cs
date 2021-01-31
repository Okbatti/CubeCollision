using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 0.1f;
    public GameObject completeLevelUI;
    public GameObject lostLevelUI;
    public GameObject PauseUI;
    public GameObject MenuUI;
    public GameObject GameOverUI;
    public bool pauseNoMore = false;
    public bool menuNoMore = false;
    public Text levelTitle;

    public void CompleteLevel()
    {
            if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                GameOverUI.SetActive(true);
                completeLevelUI.SetActive(false);
                levelTitle.GetComponent<Text>().enabled = false;
            }
            else
            {
                completeLevelUI.SetActive(true);
                levelTitle.GetComponent<Text>().enabled = false;
            }
    }

    public void LostLevel()
    {
        lostLevelUI.SetActive(true);
        Score.score = 0;
        levelTitle.GetComponent<Text>().enabled = false;
    }

    public void MenuPanel()
    {
        if (menuNoMore == false)
        {
            MenuUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void PauseGame()
    {
        if (pauseNoMore == false)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void PauseButtonContinueGame()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void MenuToHome()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void MenuButtonPauseContinueGame()
    {
        MenuUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("LostLevel", restartDelay);
        }
        pauseNoMore = true;
        menuNoMore = true;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Score.score = 0;
    }

    //after player collides and loses then this function is used.
    /*void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/

    public void ReturnHome()
    {
        SceneManager.LoadScene(0);
        Score.score = 0;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Controls()
    {
        SceneManager.LoadScene("PlayerSkin");
    }

    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void StartLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void StartLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void StartLevel4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void StartLevel5()
    {
        SceneManager.LoadScene("Level5");
    }

    public void StartLevel6()
    {
        SceneManager.LoadScene("Level6");
    }

    public void StartLevel7()
    {
        SceneManager.LoadScene("Level7");
    }

    public void StartLevel8()
    {
        SceneManager.LoadScene("Level8");
    }

    public void StartLevel9()
    {
        SceneManager.LoadScene("Level9");
    }

    public void StartLevel10()
    {
        SceneManager.LoadScene("Level10");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
