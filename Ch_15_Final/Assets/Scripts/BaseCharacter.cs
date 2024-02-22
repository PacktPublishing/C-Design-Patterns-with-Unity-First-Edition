using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : ICharacter
{
    private SOData _data;

    public BaseCharacter(SOData data)
    {
        _data = data;
    }

    public int Strength()
    {
        return _data.Strength;
    }

    public void Battle()
    {
        Debug.Log($"Character ready to battle!");
    }
}