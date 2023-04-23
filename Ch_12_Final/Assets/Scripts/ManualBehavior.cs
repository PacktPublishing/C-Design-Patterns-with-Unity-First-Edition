using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Manual Control", menuName = "SOStrategy/Manual")]
public class ManualBehavior : SOStrategy
{
    public string ForwardInput;
    public string TurnInput;

    public override void Think()
    {
        Debug.LogFormat($"Player Behavior -> Manual Control...");
    }

    public override void React(BehaviorContext context)
    {
        float horInput = Input.GetAxis(ForwardInput) * context.Player.MoveSpeed;
        float verInput = Input.GetAxis(TurnInput) * context.Player.TurnSpeed;

        Vector3 movement = Vector3.forward * horInput;
        Vector3 turn = Vector3.up * verInput;

        context.Player.ConfigureInput(movement, turn);
    }
}