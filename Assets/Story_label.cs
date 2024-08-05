using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story_label : MonoBehaviour
{
    // Start is called before the first frame update
    int val = GlobalVariables.myVariable;
    //public GameObject label2;
    void Start()
    {
        if (val == 1)
        {
            gameObject.SetActive(true);
           
        }
        Debug.Log(val);
    }

    // Update is called once per frame
    void Update()
    {
        if (val == 1)
        {
            gameObject.SetActive(true);

        }

    }
}
