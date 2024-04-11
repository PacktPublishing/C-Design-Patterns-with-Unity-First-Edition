using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceBootstrapper
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
    public static void Init()
    {
        Debug.Log("Registering services...");

        GenericLocator.Register<ILogContract>(new SystemDebugger());
        GenericLocator.Register<ISaveContract>(new CloudStorage());

        Debug.Log("Services registered");
    }
}