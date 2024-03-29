using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TerrainType { Ground, Water, Grass, Edge }

public class Tile : IFlyweight
{
    public TerrainType type { get; }
    public Color color { get; }
    public float height { get; }
    public float size { get; }

    public Tile(TerrainType type, Color color, float height)
    {
        this.type = type;
        this.color = color;
        this.height = height;
        this.size = 1;
    }

    public void Create(ExtrinsicState context)
    {
        Vector3 position = new Vector3(context.xCoord, 0, context.zCoord);
        Vector3 scale = new Vector3(size, height, size);
        GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer renderer = tile.GetComponent<Renderer>();

        tile.name = $"{type.ToString()} Tile";
        renderer.material.SetColor("_Color", color);
        tile.transform.position = position;
        tile.transform.localScale = scale;
        tile.transform.SetParent(context.parent);
    }
}