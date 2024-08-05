using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class toggleCon : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle toggle1;
    public GameObject objectToDisable;
    private Toggle toggleComponent;
    void Start()
    {
        toggle1.onValueChanged.AddListener(delegate { Toggleoff(toggle1); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Toggleoff(Toggle toggle)
    {
        // Check if Toggle1 is on
        toggleComponent = objectToDisable.GetComponent<Toggle>();
        if (toggle.isOn)
        {
            // Disable the objectToDisable when Toggle1 is on
            toggleComponent.isOn = false;
        }
        //else
        //{
        //    // Enable the objectToDisable when Toggle1 is off
        //    // objectToDisable.Toggle.SetActive(true);
        //    toggleComponent.isOn = true;
        //}
    }
}
