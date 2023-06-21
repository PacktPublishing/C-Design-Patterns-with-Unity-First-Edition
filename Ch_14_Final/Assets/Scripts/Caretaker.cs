using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caretaker
{
    public SaveMemento Memento;

    public string GetMetadata()
    {
        return Memento.Date;
    }
}