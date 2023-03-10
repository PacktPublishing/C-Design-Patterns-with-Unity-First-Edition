using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void SetColor(Color newColor)
    {
        var renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", newColor);
    }
}