using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyContext : MonoBehaviour
{
    public int MovementSpeed;

    [HideInInspector]
    public Vector3 TargetPosition;
    [HideInInspector]
    public Rigidbody Rigidbody;

    private IEnemyStrategy _strategy;

    void Start()
    {
        TargetPosition = FindObjectOfType<Player>().transform.position;
        Rigidbody = this.GetComponent<Rigidbody>();
    }

    public void SetStrategy(IEnemyStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Execute()
    {
        _strategy.Think();
        _strategy.React(this);
    }
}