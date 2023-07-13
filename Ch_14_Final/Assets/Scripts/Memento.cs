using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Memento
{
    public float HP { get; protected set; }
    public float MP { get; protected set; }
    public float INT { get; protected set; }

    private DateTime _date;

    public Memento(float hp, float mp, float intel)
    {
        HP = hp;
        MP = mp;
        INT = intel;
        _date = DateTime.Now;

        Debug.Log($"New memento created at {_date}");
    }
}