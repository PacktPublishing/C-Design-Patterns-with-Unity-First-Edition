using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndState : BaseBattleState
{
    public EndState(BattleSM sm) : base(sm) { }

    public override IEnumerator Enter()
    {
        Debug.Log("Saving game data...");
        Application.Quit();

        yield break;
    }
}