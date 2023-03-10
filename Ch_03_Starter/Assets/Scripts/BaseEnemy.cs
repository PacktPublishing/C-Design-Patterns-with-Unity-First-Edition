using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    [SerializeField] protected int Damage;
    [SerializeField] protected string Message;
    [SerializeField] protected string Name;

    public void OnEnable()
    {
        Debug.LogFormat($"{Message} - an {Name} entered the arena.");
    }

    public virtual void Attack()
    {
        Debug.LogFormat($"{Name} attacks for {Damage} HP!");
    }
}