using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static readonly object _threadLock = new object();
    private static bool _isQuitting = false;

    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_isQuitting)
            {
                return null;
            }

            if (_instance == null)
            {
                _instance = FindAnyObjectByType<T>();

                lock (_threadLock)
                {
                    if (_instance == null)
                    {
                        var singletonGO = new GameObject();
                        singletonGO.name = typeof(T).Name + " (Persists)";
                        _instance = singletonGO.AddComponent<T>();

                        DontDestroyOnLoad(singletonGO);
                        Debug.Log("New instance created!");
                    }
                }
            }

            return _instance;
        }
    }

    public void OnDestroy()
    {
        _isQuitting = true;
    }
}