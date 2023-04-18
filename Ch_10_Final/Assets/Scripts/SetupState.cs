using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupState : BaseBattleState
{
    public SetupState(BattleSM sm) : base(sm) { }

    public override IEnumerator Enter()
    {
        Debug.Log("Setting up the arena...");

        yield return new WaitForSeconds(2);
        _stateMachine.ChangeStateTo(_stateMachine.PlayerTurn);
    }

    public override IEnumerator Exit()
    {
        Debug.Log("Battle engaged!");
        yield break;
    }
}