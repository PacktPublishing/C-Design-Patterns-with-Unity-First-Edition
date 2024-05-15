using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullLogger : ILogContract
{
    public void Log(string message)
    {
        Debug.LogWarning($"{GetType().Name} service being used!");
    }

    public void Throw(string message)
    {
        Debug.LogWarning($"{GetType().Name} service being used!");
    }
}