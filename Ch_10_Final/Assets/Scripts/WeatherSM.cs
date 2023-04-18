using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherSM : SMContext
{
    public State Sunny;
    public State Cloudy;

    void Start()
    {
        Sunny = new SunnyState(this);
        Cloudy = new CloudyState(this);

        ChangeStateTo(Sunny);
    }
}