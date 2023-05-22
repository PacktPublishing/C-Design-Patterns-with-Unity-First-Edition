using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions
{
    public static class CustomExtensions
    {
        public static Color Mix(this Color colorA, Color colorB)
        {
            float red = colorA.r + colorB.r / 2;
            float green = colorA.g + colorB.g / 2;
            float blue = colorA.b + colorB.b / 2;

            return new Color(red, green, blue);
        }
    }
}