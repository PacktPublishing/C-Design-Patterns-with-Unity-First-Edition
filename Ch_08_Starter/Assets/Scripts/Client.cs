using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputListener))]
[RequireComponent(typeof(Invoker))]
[RequireComponent(typeof(UnitController))]
public class Client : MonoBehaviour
{
    private InputListener _inputListener;
    private Invoker _invoker;
    private UnitController _unitController;

    void Awake()
    {
        _inputListener = this.GetComponent<InputListener>();
        _invoker = this.GetComponent<Invoker>();
        _unitController = this.GetComponent<UnitController>();
    }
}