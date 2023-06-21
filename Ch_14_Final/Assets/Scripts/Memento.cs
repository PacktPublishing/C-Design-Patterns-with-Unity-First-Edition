using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Memento
{
    public float MoveSpeed { get; private set; }
    public float TurnSpeed { get; private set; }
    public Vector3 LastCheckpoint { get; private set; }

    public Memento(float move, float turn, Vector3 position)
    {
        this.MoveSpeed = move;
        this.TurnSpeed = turn;
        this.LastCheckpoint = position;
    }
}

public class SaveMemento
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public string Date { get; private set; }

    public SaveMemento(string name, int level)
    {
        this.Name = name;
        this.Level = level;
        this.Date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
    }
}