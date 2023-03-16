using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputListener))]
[RequireComponent(typeof(Invoker))]
public class Client : MonoBehaviour
{
    public UnitManager unitManager;

    private InputListener _inputListener;
    private Invoker _invoker;

    void Awake()
    {
        _inputListener = this.GetComponent<InputListener>();
        _invoker = this.GetComponent<Invoker>();
    }

    void Update()
    {
        var reusableCommand = _inputListener.GetActionCommands();
        if (reusableCommand != null)
        {
            Debug.Log("Reusable command input received...");
            _invoker.Execute(reusableCommand, unitManager.unit);
        }

        var coupledCommand = _inputListener.GetMoveComamands();
        if (coupledCommand != null)
        {
            Debug.Log("Coupled command input received...");
            _invoker.Execute(coupledCommand);
        }

        if(Input.GetKeyDown(KeyCode.U))
        {
            _invoker.Undo();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            _invoker.Redo();
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            _invoker.Confirm();
        }
    }
}