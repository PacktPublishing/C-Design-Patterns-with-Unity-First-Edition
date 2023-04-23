using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Noob", menuName = "SOStrategy/Noob")]
public class NoobBehavior : SOStrategy
{
    public override void Think()
    {
        Debug.LogFormat($"Player Behavior -> Complete noob...");
    }

    public override void React(BehaviorContext context)
    {
        Vector3 movement = Vector3.forward * context.Player.MoveSpeed;
        Vector3 turning = Vector3.up * context.Player.TurnSpeed;

        context.Player.ConfigureInput(movement, turning);
    }
}