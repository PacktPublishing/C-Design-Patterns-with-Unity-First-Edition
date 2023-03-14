using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Text BlueprintLog;

    public void Build()
    {
        IBuilder builder = new TankBuilder();
        var fluentAlly = builder    
            .BuildFrame()    
            .BuildMotor()    
            .BuildWeapon()    
            .GetAlly();

        //Director director = new Director();    

        //director.ConstructWith(builder);    
        //var ally = builder.GetAlly();    

        BlueprintLog.text = fluentAlly.GetBlueprint();    
    }
}