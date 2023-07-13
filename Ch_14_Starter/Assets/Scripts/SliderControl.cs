using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliderControl : MonoBehaviour
{
    public TMP_Text Textfield;

    public void OnSliderChanged(float value)
    {
        Textfield.text = value.ToString();
    }
}