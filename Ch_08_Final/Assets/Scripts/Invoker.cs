using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    private Stack<CoupledCommand> _commands = new Stack<CoupledCommand>();
    private Stack<CoupledCommand> _redo = new Stack<CoupledCommand>();
    private int _maxMoves = 6;

    public void Execute(ReusableCommand command, UnitController receiver)
    {
        Debug.Log($"{command.ToString()} invoked...");
        command.Execute(receiver);
    }

    public void Execute(CoupledCommand command)
    {
        if (_commands.Count < _maxMoves)
        {
            Debug.Log($"{command.ToString()} invoked...");

            _commands.Push(command);
            _redo.Clear();
            command.Execute();
        }
        else
        {
            Debug.Log("Out of moves...");
        }
    }

    public void Undo()
    {
        if (_commands.Count > 0)
        {
            var lastCommand = _commands.Pop();
            lastCommand.Undo();
            _redo.Push(lastCommand);

            Debug.Log("Command undone...");
        }
    }

    public void Redo()
    {
        if (_redo.Count > 0)
        {
            var lastCommand = _redo.Pop();
            lastCommand.Execute();
            _commands.Push(lastCommand);

            Debug.Log("Command redone...");
        }
    }

    public void Confirm()
    {
        _commands.Clear();
        _redo.Clear();

        Debug.Log("Moves confirmed!");
    }
}