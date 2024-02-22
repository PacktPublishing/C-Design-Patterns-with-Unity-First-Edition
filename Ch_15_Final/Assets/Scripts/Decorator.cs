using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Decorator : ICharacter
{
    protected ICharacter _character;
    protected SOData _data;

    public Decorator(ICharacter character, SOData data)
    {
        _character = character;
        _data = data;
    }

    public virtual int Strength()
    {
        return _character.Strength() + _data.Strength;
    }

    public virtual void Battle()
    {
        Debug.Log($"Strength decorator => Str + {_data.Strength}");
        Debug.Log($"Applying decorator => Str: {Strength()}");
        _character.Battle();
    }
}