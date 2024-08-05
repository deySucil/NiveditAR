using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
    public Toggle eng;
    public Toggle beng;
    //public GameObject eng_panel;
    //public GameObject beng_panel;
    public void activeToggle()
    {
        if(eng.isOn)
        {
            Debug.Log("English");
        }
        else if(beng.isOn)
        {
            GlobalVariables.myVariable = 2;
        }
    }
    private void Update()
    {
        Debug.Log(GlobalVariables.myVariable);
    }

}
