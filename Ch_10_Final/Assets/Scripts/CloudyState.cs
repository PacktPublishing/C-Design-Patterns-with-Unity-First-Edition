using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudyState : State
{
    protected WeatherSM _stateMachine;

    public CloudyState(WeatherSM sm)
    {
        _stateMachine = sm;
    }

    public override IEnumerator Enter()
    {
        Manager.Instance.NightToDay();
        yield break;
    }

    public override void CheckState()
    {
        if (Manager.Instance.daylight.intensity == 1.0f)
        {
            _stateMachine.ChangeStateTo(_stateMachine.Sunny);
        }
    }
}