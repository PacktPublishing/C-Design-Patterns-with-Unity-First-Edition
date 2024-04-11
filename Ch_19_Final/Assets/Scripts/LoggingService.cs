using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface ILogContract
{
    void Log(string message);
    void Throw(string message);
}

public class SystemDebugger : ILogContract
{
    public void Log(string message)
    {
        DateTime time = new DateTime();
        Debug.Log($"{time.Date}: {message}");
    }

    public void Throw(string message)
    {
        DateTime time = new DateTime();
        throw new Exception($"{time.Date}: {message}");
    }
}

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