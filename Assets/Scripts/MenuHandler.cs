using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR 
using UnityEditor;
#endif

public class MenuHandler : MonoBehaviour
{
    // Method for Mad Driver button
    public void LoadMadDriver()
    {
        SceneManager.LoadScene("Mad Driver");
    }

    // Method for Fly Like a Bird button
    public void LoadFlyLikeABird()
    {
        SceneManager.LoadScene("Fly Like a Bird");
    }

    // Method for Sumo game button
    public void LoadSumoGame()
    {
        SceneManager.LoadScene("I'm a Sumo and a Ball");
    }

    // Method for Exit button
    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}