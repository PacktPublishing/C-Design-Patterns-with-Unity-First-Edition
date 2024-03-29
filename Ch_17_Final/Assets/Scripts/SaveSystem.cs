using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem
{
    public void Save(float score)
    {
        PlayerPrefs.SetFloat("score", score);
        Debug.Log("New score saved...");
    }
}