using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenOrient : MonoBehaviour
{
    // Start is called before the first frame update
   public void Set_portr()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void Set_land()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
