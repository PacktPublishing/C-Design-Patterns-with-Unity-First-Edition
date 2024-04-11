using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaveContract
{
    void Save(string data);
    void Load();
}

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