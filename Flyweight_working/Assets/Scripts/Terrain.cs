using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public abstract class Terrain
{
    public GameObject Prefab { get; protected set; }
    public Texture Texture { get; protected set; }

    public abstract void Create(Vector3 position, int length);
}

public class Lumber : Terrain
{
    public static event Action<int> TerrainSpawned;

    private Transform _transform;
    private Rigidbody _rb;

    public Lumber()
    {
        Prefab = Resources.Load<GameObject>("LumberPrefab");
        Texture = Resources.Load<Texture>("LumberTexture");
        _transform = Prefab.GetComponent<Transform>();
        _rb = Prefab.GetComponent<Rigidbody>();
    }

    public override void Create(Vector3 position, int length)
    {
        var adjustedScale = _transform.localScale;
        adjustedScale.x = length;
        _transform.localScale = adjustedScale;

        var resource = GameObject.Instantiate(Prefab, position, Quaternion.identity);
        var renderer = resource.GetComponent<Renderer>();
        renderer.material.mainTexture = Texture;

        _rb.AddForce(Vector3.up, ForceMode.Impulse);

        TerrainSpawned?.Invoke(Random.Range(1, 10));
    }
}

public class TerrainFactory
{
    private Dictionary<string, Terrain> _cache = new Dictionary<string, Terrain>();

    public Terrain GetResource(string resourceName)
    {
        Terrain resource = null;

        if (_cache.ContainsKey(resourceName))
        {
            Debug.LogFormat($"Reusing {resourceName} object...");
            resource = _cache[resourceName];
        }
        else
        {
            Debug.LogFormat($"Creating new {resourceName} Flyweight...");
            resource = new Lumber();
            _cache.Add(resourceName, resource);
        }

        return resource;
    }
}