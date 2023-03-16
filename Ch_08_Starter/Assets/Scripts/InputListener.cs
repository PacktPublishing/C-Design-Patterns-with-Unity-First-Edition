using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    public UIManager UI;
    public UnitManager unitManager;

    private Vector3 TargetPosition(Direction direction)
    {
        Vector3 position = unitManager.unit.transform.position;

        switch (direction)
        {
            case Direction.Up:
                position.z += 1;
                break;
            case Direction.Down:
                position.z -= 1;
                break;
            case Direction.Left:
                position.x -= 1;
                break;
            case Direction.Right:
                position.x += 1;
                break;
        }

        return position;
    }
}