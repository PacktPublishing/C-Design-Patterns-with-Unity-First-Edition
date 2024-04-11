using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GenericLocator
{
    private static readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();
    public static int Services
    {
        get { return _services.Count; }
    }

    public static void Register<T>(T newService) where T : class
    {
        Type key = typeof(T);
        if (newService == null)
        {
            _services[key] = FindNullObject<T>();
            Debug.Log($"Null {key} registered...");
        }
        else if (!_services.ContainsKey(key))
        {
            _services[key] = newService;
            Debug.Log($"{key} service  registered...");
        }
        else
        {
            Debug.Log($"{key} service already registered...");
        }
    }

    public static void RegisterExplicit(Type type, object newService)
    {
        if (!type.IsInstanceOfType(newService))
        {
            throw new Exception($"Service type [{type.FullName}] doesn't match service interface [{nameof(newService)}]!");
        }

        if (!_services.ContainsKey(type))
        {
            _services[type] = newService;
            Debug.Log($"{type.FullName} service  registered...");
        }
        else
        {
            Debug.Log($"{type.FullName} service already registered...");
        }
    }

    public static T GetService<T>() where T : class
    {
        Type key = typeof(T);
        try
        {
            return _services[key] as T;
        }
        catch
        {
            return FindNullObject<T>();
        }
    }

    public void Unregister<T>()
    {
        Type key = typeof(T);
        if (!_services.ContainsKey(key))
        {
            Debug.Log($"{key.FullName} service has not been registered...");
        }
        else
        {
            _services.Remove(key);
        }
    }

    static T FindNullObject<T>() where T : class
    {
        Type key = typeof(T);
        switch (key.Name)
        {
            case nameof(ILogContract):
                return new NullLogger() as T;
            case nameof(ISaveContract):
                return new NullSaver() as T;
            default:
                return new NullLogger() as T;
        }
    }
}