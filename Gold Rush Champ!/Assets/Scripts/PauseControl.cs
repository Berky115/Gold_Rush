using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public bool gameIsPaused;
    public GameObject pauseMenu;

    void Start()
    {
        gameIsPaused = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
                pauseMenu.SetActive(false);
            }
            else
            {
                Pause();
                pauseMenu.SetActive(true);
            }
        }
    }

    public void Resume()
    {
        gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        gameIsPaused = true;
        Time.timeScale = 0f;
    }
}
