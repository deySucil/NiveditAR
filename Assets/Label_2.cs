using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Label_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle toggle2;

    // Update is called once per frame
    void Update()
    {
        if(toggle2.isOn)
        {
            GlobalVariables.myVariable = 2;
        }
    }
}
