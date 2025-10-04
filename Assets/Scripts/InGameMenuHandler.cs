using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenuHandler : MonoBehaviour
{
    [Header("In-Game Menu UI")]
    public GameObject inGameMenuPanel;

    [Header("Game State")]
    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure game starts unpaused
        Time.timeScale = 1f;
        isPaused = false;

        // Make sure menu panel starts hidden
        if (inGameMenuPanel != null)
        {
            inGameMenuPanel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Requirement 7: [5 marks] In the game, on press the Escape key, pause the game.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    // Method to pause the game when Escape is pressed
    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f; // Pause the game

        if (inGameMenuPanel != null)
        {
            inGameMenuPanel.SetActive(true); // Show the in-game menu
        }
        Debug.Log("Game Paused - isPaused: " + isPaused + ", TimeScale: " + Time.timeScale);
    }


    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // Resume the game

        if (inGameMenuPanel != null)
        {
            inGameMenuPanel.SetActive(false); // Hide the in-game menu
        }
        Debug.Log("Game Resumed - isPaused: " + isPaused + ", TimeScale: " + Time.timeScale);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Make sure time scale is reset
        //debug
        Debug.Log("Restarting Game");
        Debug.Log(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload current scene
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f; // Make sure time scale is reset
        SceneManager.LoadScene("Main Menu"); // Load the Main Menu scene
    }
}
