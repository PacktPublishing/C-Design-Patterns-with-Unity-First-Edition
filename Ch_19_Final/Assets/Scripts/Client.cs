using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    void Awake()
    {
        // GenericLocator.Register<ILogContract>(new SystemDebugger());
        // GenericLocator.Register<ISaveContract>(new CloudStorage());

        Debug.Log($"Services registered: {GenericLocator.Services}");
    }
}