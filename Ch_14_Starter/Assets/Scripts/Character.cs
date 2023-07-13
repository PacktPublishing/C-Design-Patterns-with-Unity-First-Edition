using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Character
{
    public float HP { get; protected set; }
    public float MP { get; protected set; }
    public float INT { get; protected set; }

    public void SetData(float hp, float mp, float intel)
    {
        HP = hp;
        MP = mp;
        INT = intel;

        Debug.Log($"Initial state -> HP: {HP}, MP: {MP}, INT: {INT}");
    }
}