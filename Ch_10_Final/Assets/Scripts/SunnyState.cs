using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunnyState : State
{
    protected WeatherSM _stateMachine;

    public SunnyState(WeatherSM sm)
    {
        _stateMachine = sm;
    }

    public override IEnumerator Enter()
    {
        Manager.Instance.DayToNight();
        yield break;
    }

    public override void CheckState()
    {
        if (Manager.Instance.daylight.intensity == 0.25f)
        {
            _stateMachine.ChangeStateTo(_stateMachine.Cloudy);
        }
    }
}