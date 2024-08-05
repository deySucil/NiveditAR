using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Changecolor : MonoBehaviour
{
    // Start is called before the first frame update
    public Image imagecolor;
    public Color color1;
    public void ColorChange()
    {
        imagecolor.tintColor = color1;
    }
}
