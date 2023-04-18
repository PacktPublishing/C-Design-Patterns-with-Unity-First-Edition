using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : BaseBattleState
{
    private bool isKO;
    private int movesRemaining;

    public PlayerState(BattleSM sm) : base(sm) { }

    public override IEnumerator Enter()
    {
        Debug.Log("Finally, my turn!");
        Manager.Instance.Player.ChangeColor(Color.green);
        movesRemaining = 1;

        yield break;
    }

    public override void HandleInput()
    {
        if (!Manager.Instance.isPaused)
        {
            if (Input.GetKeyDown(KeyCode.A) && movesRemaining > 0)
            {
                movesRemaining--;
                isKO = Manager.Instance.Enemy.TakeDamage(1);
            }
            else if (Input.GetKeyDown(KeyCode.H) && movesRemaining > 0)
            {
                movesRemaining--;
                Manager.Instance.Player.Heal();
            }
            else
            {
                base.HandleInput();
            }
        }
        else
        {
            base.HandleInput();
        }
    }

    public override void CheckState()
    {
        if (isKO)
        {
            _stateMachine.ChangeStateTo(_stateMachine.EndBattle);
        }
        else if (movesRemaining == 0)
        {
            _stateMachine.ChangeStateTo(_stateMachine.EnemyTurn);
        }
    }

    public override IEnumerator Exit()
    {
        yield return new WaitForSeconds(1);

        Debug.Log("I'm out of energy...");
        Manager.Instance.Player.ChangeColor(Color.blue);
    }
}