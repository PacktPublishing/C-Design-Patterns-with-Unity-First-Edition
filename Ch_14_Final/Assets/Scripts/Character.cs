using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Character : MonoBehaviour
{
    [field: SerializeField]
    public float HP { get; protected set; }

    [field: SerializeField]
    public float MP { get; protected set; }

    [field: SerializeField]
    public float INT { get; protected set; }

    public void OnHPChanged(float value) => HP = value;
    public void OnMPChanged(float value) => MP = value;
    public void OnINTChanged(float value) => INT = value;

    public Memento CreateMemento()
    {
        Debug.Log("Creating new memento...");
        return new Memento(HP, MP, INT);
    }

    public void RestoreMemento(Memento memento)
    {
        HP = memento.HP;
        MP = memento.MP;
        INT = memento.INT;

        Debug.Log("Restored to previous memento state...");
    }
}