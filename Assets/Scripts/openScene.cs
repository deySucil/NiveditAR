using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene_next()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene by incrementing the current scene index
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadScene_2()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    private void Update()
    {
       Input.backButtonLeavesApp = true;
    }
}
