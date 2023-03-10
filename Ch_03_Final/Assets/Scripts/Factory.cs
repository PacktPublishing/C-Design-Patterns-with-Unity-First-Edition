using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory<T>
{
    private Dictionary<string, T> objects = new Dictionary<string, T>();

    public T this[string key]
    {
        get { return objects[key]; }
        set { objects.Add(key, value); }
    }
}