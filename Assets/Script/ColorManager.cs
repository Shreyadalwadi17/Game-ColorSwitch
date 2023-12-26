using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public List<Color> colorlist=new List<Color>();
    public Color mycolor;
    public static ColorManager  inst;
    public colorType currentcolor;   

 
    public void ColorChange()
    {
        Debug.LogWarning("COLOR: " + currentcolor);
        int value = Random.Range(0, colorlist.Count);
        Debug.Log("Green: "+ colorType.green.ToString());
        mycolor= colorlist[value];

        switch(value)
        {
            case 0:
                currentcolor = colorType.Yellow;
                break;

            case 1:
                currentcolor = colorType.Skyblue;
                break;
            case 2:
                currentcolor = colorType.green;
                break;
            case 3:
                currentcolor = colorType.Red;
                break;

        }
    }


   
}
