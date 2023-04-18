using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : BaseBattleState
{
    private bool isKO;
    private int movesRemaining;

    public EnemyState(BattleSM sm) : base(sm) { }

    public override IEnumerator Enter()
    {
        Debug.Log("You don't stand a chance!");
        Manager.Instance.Enemy.ChangeColor(Color.green);
        movesRemaining = 1;

        yield return new WaitForSeconds(1);

        isKO = Manager.Instance.Player.TakeDamage(1);
        movesRemaining--;

        _stateMachine.history.Pop();
    }

    public override void CheckState()
    {
        if (isKO)
        {
            _stateMachine.ChangeStateTo(_stateMachine.EndBattle);
        }
        else if (movesRemaining == 0)
        {
            _stateMachine.ChangeStateTo(_stateMachine.history.Peek());
        }
    }

    public override IEnumerator Exit()
    {
        yield return new WaitForSeconds(1);

        Debug.Log("I'll get you next time...");
        Manager.Instance.Enemy.ChangeColor(Color.magenta);
    }
}