using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory<T>
{
    private Dictionary<string, T> objects = new Dictionary<string, T>();
    public T this[string key]
    {
        get
        {
            if (objects.ContainsKey(key))
            {
                return objects[key];
            }
            else
            {
                throw new KeyNotFoundException("Key not found: " + key);
            }
        }
        set
        {
            if (objects.ContainsKey(key))
            {
                objects[key] = value;
            }
            else
            {
                objects.Add(key, value);
            }
        }
    }
}