using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    public UIManager UI;

    private UnitController _unitController;
    private ReusableCommand _spacebar, _mKey, _bKey;

    void Start()
    {
        _spacebar = new BlockCommand();
        _mKey = new ShootCommand();
        _bKey = new MeleeCommand();

        UI.AddKeyBinding("Space", _spacebar.ToString());
        UI.AddKeyBinding("M", _mKey.ToString());
        UI.AddKeyBinding("B", _bKey.ToString());

        _unitController = this.GetComponent<UnitController>();
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

    public CoupledCommand GetMoveComamands()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            return new MoveCommand(_unitController.unit, Direction.Up);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            return new MoveCommand(_unitController.unit, Direction.Down);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            return new MoveCommand(_unitController.unit, Direction.Left);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            return new MoveCommand(_unitController.unit, Direction.Right);
        }

        return null;    
    }
}