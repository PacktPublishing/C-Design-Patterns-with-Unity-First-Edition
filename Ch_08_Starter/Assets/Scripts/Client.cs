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
}