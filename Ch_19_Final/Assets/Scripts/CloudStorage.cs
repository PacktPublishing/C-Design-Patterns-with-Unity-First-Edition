using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudStorage : ISaveContract
{
    public void Save(string data)
    {
        Debug.Log($"{data} saved to database...");
    }

    public void Load()
    {
        Debug.Log($"Data loaded from database...");
    }
}