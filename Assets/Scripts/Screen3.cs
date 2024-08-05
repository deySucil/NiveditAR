using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen3 : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene_3()
    {
        //Screen.orientation = ScreenOrientation.Portrait;
        SceneManager.LoadScene(3);
    }

    // Update is called once per frame
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
        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene by incrementing the current scene index
        //Screen.orientation = ScreenOrientation.Portrait;
        SceneManager.LoadScene(3);
    }
}
