using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLocator
{
    private static ILogContract _logging;
    private static ISaveContract _saving;

    private static ILogContract _nullLogger = new NullLogger();
    private static ISaveContract _nullSaver = new NullSaver();

    public static void Initialize()
    {
        _logging = _nullLogger;
        _saving = _nullSaver;
    }

    public static void RegisterLogger(ILogContract service)
    {
        if (service == null)
        {
            _logging = _nullLogger;
        }
        else
        {
            _logging = service;
            Debug.Log("Logging service registered...");
        }
    }

    public static void RegisterSaver(ISaveContract service)
    {
        if (service == null)
        {
            _saving = _nullSaver;
        }
        else
        {
            _saving = service;
            Debug.Log("Saving service registered...");
        }
    }

    public static ILogContract GetLogService()
    {
        return _logging;
    }

    public static ISaveContract GetSaveService()
    {
        return _saving;
    }
}