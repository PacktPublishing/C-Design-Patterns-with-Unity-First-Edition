using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullSaver : ISaveContract
{
    public void Save(string data)
    {
        Debug.LogWarning($"{GetType().Name} service being used!");
    }

    public void Load()
    {
        Debug.LogWarning($"{GetType().Name} service being used!");
    }
}