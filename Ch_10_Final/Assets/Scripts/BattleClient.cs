using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Manager))]
public class BattleClient : MonoBehaviour
{
    private BattleSM Battle;
    private WeatherSM Weather;

    void Start()
    {
        Battle = GetComponent<BattleSM>();
        Weather = GetComponent<WeatherSM>();
    }

    void Update()
    {
        Battle.HandleInput();
        Battle.CheckState();

        Weather.HandleInput();
        Weather.CheckState();
    }
}