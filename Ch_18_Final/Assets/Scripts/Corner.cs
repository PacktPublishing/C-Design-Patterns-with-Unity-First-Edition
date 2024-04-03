using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corner : IFlyweight
{
    private IFlyweight _tile;
    private List<Vector2Int> _intersects;
    private ExtrinsicState _context;

    public Corner()
    {
        _tile = SOFactory.GetFlyweight(TerrainType.Edge);
    }

    public void Create(ExtrinsicState context)
    {
        _context = context;
        _intersects = Utilities.GetIntersectTiles(context.xCoord, context.zCoord);
        _tile.Create(context);

        foreach (Vector2Int position in _intersects)
        {
            context.xCoord = position.x;
            context.zCoord = position.y;
            _tile.Create(context);
        }
    }
}