using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool gamePaused = false;
    public GameObject pauseMenuUI;
    public string sceneRestartGame = "SampleScene";
    public string sceneRestartLevel = "SampleScene";


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; //verslomen of stoppen van tijd
        gamePaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Scene0_Menu");
    }
    public void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
    public void RestartLevel1()
    {
        SceneManager.LoadScene(sceneRestartLevel);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(sceneRestartGame);
    }

}
