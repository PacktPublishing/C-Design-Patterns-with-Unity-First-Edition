using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class BehaviorContext : MonoBehaviour
{
    public SOStrategy Strategy;

    [HideInInspector]
    public Player Player;

    void Start()
    {
        Player = GetComponent<Player>();
        Strategy.Think();
    }

    void Update()
    {
        Strategy.React(this);
    }
}