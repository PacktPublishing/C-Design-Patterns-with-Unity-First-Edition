using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director    
{
    public void ConstructWith(IBuilder builder)    
    {
        builder.BuildFrame();    
        builder.BuildMotor();    
        builder.BuildWeapon();    
    }
}