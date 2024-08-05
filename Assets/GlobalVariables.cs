using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    // Start is called before the first frame update
    public static int myVariable = 0;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        Debug.Log(myVariable);
    }

}
