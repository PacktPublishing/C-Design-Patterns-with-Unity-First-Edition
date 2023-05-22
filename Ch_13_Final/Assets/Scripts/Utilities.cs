using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities
{
    public static Color MixColors(Color firstColor, Color secondColor)
    {
        float red = firstColor.r + secondColor.r / 2;
        float green = firstColor.g + secondColor.g / 2;
        float blue = firstColor.b + secondColor.b / 2;

        return new Color(red, green, blue);
    }
}