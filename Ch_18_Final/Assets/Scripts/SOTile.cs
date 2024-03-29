using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tile Data", menuName = "ScriptableObjects/SO Tile")]
public class SOTile : ScriptableObject, IFlyweight
{
    public TerrainType type;
    public Color color;
    public float height;
    public float size;

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