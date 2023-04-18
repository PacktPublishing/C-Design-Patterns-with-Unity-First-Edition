using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSM : SMContext
{
    public State Setup;
    public State PlayerTurn;
    public State EnemyTurn;
    public State EndBattle;

    void Start()
    {
        Setup = new SetupState(this);
        PlayerTurn = new PlayerState(this);
        EnemyTurn = new EnemyState(this);
        EndBattle = new EndState(this);

        ChangeStateTo(Setup);
    }
}