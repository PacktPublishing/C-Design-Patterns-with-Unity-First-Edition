using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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