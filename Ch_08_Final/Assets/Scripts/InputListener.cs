using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    public UIManager UI;
    public UnitManager unitManager;

    private ReusableCommand _spacebar, _mKey, _bKey;

    void Start()
    {
        _spacebar = new BlockCommand();
        _mKey = new ShootCommand();
        _bKey = new MeleeCommand();

        UI.AddKeyBinding("Space", _spacebar.ToString());
        UI.AddKeyBinding("M", _mKey.ToString());
        UI.AddKeyBinding("B", _bKey.ToString());
    }

    public CoupledCommand GetMoveComamands()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            return new MoveCommand(unitManager.unit, TargetPosition(Direction.Up));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            return new MoveCommand(unitManager.unit, TargetPosition(Direction.Down));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            return new MoveCommand(unitManager.unit, TargetPosition(Direction.Left));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            return new MoveCommand(unitManager.unit, TargetPosition(Direction.Right));
        }

        return null;
    }

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

    public ReusableCommand GetActionCommands()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            return _mKey;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            return _bKey;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            return _spacebar;
        }

        return null;
    }
}