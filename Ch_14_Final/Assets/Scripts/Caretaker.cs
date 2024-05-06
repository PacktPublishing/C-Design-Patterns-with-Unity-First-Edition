using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Caretaker
{
    private List<Memento> _mementos = new List<Memento>();
    private Character _originator;

    public Caretaker(Character originator)
    {
        _originator = originator;
    }

    public void Save()
    {
        _mementos.Add(_originator.CreateMemento());
    }

    public void RestoreLast()
    {
        if(_mementos.Count == 0)
        {
            _originator.RestoreMemento(new Memento(0, 0, 0));
            return;
        }

        var lastMemento = _mementos.Last();
        _mementos.Remove(lastMemento);

        _originator.RestoreMemento(lastMemento);
    }
}