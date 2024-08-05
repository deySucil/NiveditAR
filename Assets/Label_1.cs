using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Label_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle toggle;
    private void Update()
    {
        if(toggle.isOn)
        GlobalVariables.myVariable = 1;
        else GlobalVariables.myVariable = 0;
    }


}
