using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOFactory : MonoBehaviour
{
    public SOTile ground;
    public SOTile water;
    public SOTile grass;
    public SOTile edge;

    public IFlyweight GetFlyweight(TerrainType type)
    {
        switch (type)
        {
            case TerrainType.Ground:
                return ground;
            case TerrainType.Water:
                return water;
            case TerrainType.Grass:
                return grass;
            case TerrainType.Edge:
                return edge;
            default:
                return ground;
        }
    }

    public Corner GetCorner()
    {
        return new Corner();
    }
}
