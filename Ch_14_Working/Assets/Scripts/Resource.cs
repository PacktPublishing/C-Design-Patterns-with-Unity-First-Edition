using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IResource
{
    public void Mine(int quantity, Vector3 origin);
}

public class CollectableResource : IResource
{
    public string Name { get; }
    public Color Color { get; }
    public PrimitiveType Object { get; }
    public GameObject GB { get; }
    public Rigidbody RB { get; }
    public Vector3 Size { get; }
    public Transform Origin { get; }
    public static event Action<int> ResourceCollected;

    public CollectableResource(string name)
    {
        Name = name;
        Color = Color.black;
        Object = PrimitiveType.Capsule;
        Size = new Vector3(0.5f, 0.5f, 0.5f);
        GB = GameObject.CreatePrimitive(Object);
        RB = GB.AddComponent<Rigidbody>();
        //Origin = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Mine(int quantity, Vector3 origin)
    {
        for(int i = 0; i < quantity; i++)
        {
            //var resourceObject = GameObject.CreatePrimitive(Object);
            GB.transform.localScale = Size;
            GB.transform.position = origin;
            RB.AddForce(Vector3.up, ForceMode.Impulse);

            ResourceCollected?.Invoke(quantity);
        }
    }
}

public class ResourceFactory
{
    private Dictionary<string, CollectableResource> _cache = new Dictionary<string, CollectableResource>();

    public CollectableResource GetResource(string resourceName)
    {
        CollectableResource resource = null;

        if (_cache.ContainsKey(resourceName))
        {
            Debug.LogFormat($"Reusing {resourceName} object...");
            resource = _cache[resourceName];
        }
        else
        {
            Debug.LogFormat($"Creating new {resourceName} Flyweight...");
            resource = new CollectableResource(resourceName);
            _cache.Add(resourceName, resource);
        }

        return resource;
    }
}