using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
    void Start()
    {
        var factory = new IronSwordUpgrade();
        var client = new Client(factory);

        client.ExecuteFactoryProcesses();
    }
}