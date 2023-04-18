using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBattleState : State
{
    protected BattleSM _stateMachine;

    public BaseBattleState(BattleSM sm)
    {
        _stateMachine = sm;
    }

    public override void HandleInput()
    {
        base.HandleInput();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Manager.Instance.Pause();
        }
    }
}