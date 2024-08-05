using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToggleScene : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle eng_tog;
    public Toggle beng_tog;
    
   public void Active_scene()
    {
        if(eng_tog.isOn)
        {
            SceneManager.LoadScene(3);
        }
        else if (beng_tog.isOn)
        {
            SceneManager.LoadScene(7);
        }
    }
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
        SceneManager.LoadScene(3);
    }
}
