using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightFactory
{
    private static Dictionary<string, IFlyweight> _cache = new Dictionary<string, IFlyweight>();

    public static IFlyweight GetFlyweight(TerrainType type)
    {
        var key = type.ToString();
        if (!_cache.ContainsKey(key))
        {
            IFlyweight newTile = null;
            switch (type)
            {
                case TerrainType.Ground:
                    newTile = new Tile(type, Color.white, 0.75f);
                    break;
                case TerrainType.Water:
                    newTile = new Tile(type, Color.blue, 0.65f);
                    break;
                case TerrainType.Grass:
                    newTile = new Tile(type, Color.green, 1.0f);
                    break;
                case TerrainType.Edge:
                    newTile = new Tile(type, Color.black, 1.5f);
                    break;
            }

            Debug.Log("New flyweight created…");
            _cache.Add(key, newTile);
        }

        Debug.Log("Flyweight returned…");
        return _cache[key];
    }

    public static Corner GetCorner()
    {
        Debug.Log("Unshared flyweight created...");
        return new Corner();
    }
}