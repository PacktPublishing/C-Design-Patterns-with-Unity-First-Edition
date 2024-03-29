using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DataConverter
{
    public float FormatScore(double score)
    {
        Debug.Log("Converting score...");
        return (float)score;
    }
}