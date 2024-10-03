using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenu;  // The UI panel for the pause menu
    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);  // Hide the pause menu at the start of the game
    }

    void Update()
    {
        // Toggle pause menu when ESC is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
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
        pauseMenu.SetActive(false);  // Hide the pause menu
        Time.timeScale = 1f;           // Resume game time
        isPaused = false;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);   // Show the pause menu
        Time.timeScale = 0f;           // Freeze game time
        isPaused = true;
    }

    public void Restart()
    {
        pauseMenu.SetActive(false);  // Hide the pause menu
        Time.timeScale = 1f;  // Ensure time is running normally
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Restart the current scene
    }

    public void QuitGame()
    {
        Application.Quit();  // Quit the application
        //Go back to the main menu
        SceneManager.LoadScene("Main Menu");
    }
    
}

