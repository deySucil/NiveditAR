using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
   public void LoadScene_1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScene_prev() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene by incrementing the current scene index
        SceneManager.LoadScene(currentSceneIndex - 1);
    }
    public void LoadScene_next()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene by incrementing the current scene index
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
   public void LoadScene_3()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadScene_4()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadScene_5()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadScene_6()
    {
        SceneManager.LoadScene(6);
    }

    //private void Update()
    //{
    //    Input.backButtonLeavesApp = true;
    //}
   

    void Update()
    {
        // Check for the Android back button press
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Handle the back button press
            HandleBackButton();
        }
    }

    void HandleBackButton()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene by incrementing the current scene index
        SceneManager.LoadScene(currentSceneIndex - 1);
    }
}
