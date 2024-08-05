using UnityEngine;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
    void Start()
    {
        // Create a new GameObject
        GameObject splashScreen = new GameObject("SplashScreen");

        // Add a RectTransform component to the GameObject
        RectTransform rectTransform = splashScreen.AddComponent<RectTransform>();

        // Set the parent of the RectTransform to the Canvas
        rectTransform.SetParent(GameObject.Find("Canvas").transform, false);

        // Set the width and height of the RectTransform
        rectTransform.sizeDelta = new Vector2(1080, 2400);

        // Add a CanvasRenderer component
        CanvasRenderer canvasRenderer = splashScreen.AddComponent<CanvasRenderer>();

        // Set the background color to white
        splashScreen.GetComponent<Renderer>().material.color = Color.white;

        // Set clipping behavior (optional)
        splashScreen.GetComponent<Mask>().enabled = true;
    }
}
