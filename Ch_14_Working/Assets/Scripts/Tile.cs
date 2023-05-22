using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile
{
    public string Name { get; protected set; }
    public Color Color { get; protected set; }
    public Vector3 Size { get; protected set; }
    public int MovementCost { get; protected set; }
}

public class Water : Tile
{
    public Water()
    {
        Name = "Water";
        Color = Color.blue;
        Size = new Vector3(1, 0.75f, 1);
        MovementCost = 2;
    }
}

public class Hill : Tile
{
    public Hill()
    {
        Name = "Hill";
        Color = Color.green;
        Size = new Vector3(1, Random.Range(0, 2.5f), 1);
        MovementCost = 1;
    }
}

public class Field : Tile
{
    public Field()
    {
        Name = "Field";
        Color = Color.yellow;
        Size = new Vector3(1, 1, 1);
        MovementCost = 1;
    }
}

public class TileFactory
{
    private Dictionary<string, Tile> _cache = new Dictionary<string, Tile>();
    public int TilesCreated => _cache.Count;

    public Tile GetTile(string tileType)
    {
        Tile tile = null;

        if(_cache.ContainsKey(tileType))
        {
            Debug.LogFormat($"Reusing {tileType} object...");
            tile = _cache[tileType];
        }
        else
        {
            Debug.LogFormat($"Creating new {tileType} Flyweight...");
            switch(tileType)
            {
                case "Water":
                    tile = new Water();
                    break;
                case "Hill":
                    tile = new Hill();
                    break;
                case "Field":
                    tile = new Field();
                    break;
            }

            _cache.Add(tileType, tile);
        }

        return tile;
    }
}