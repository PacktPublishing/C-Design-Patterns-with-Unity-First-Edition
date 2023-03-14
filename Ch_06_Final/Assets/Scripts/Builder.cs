using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBuilder    
{
    IBuilder BuildFrame();    
    IBuilder BuildMotor();    
    IBuilder BuildWeapon();    

    SupportAlly GetAlly();    
}

public class TankBuilder : IBuilder    
{
    private SupportAlly _ally;    

    public TankBuilder()    
    {
        _ally = new SupportAlly("Tank");    
    }

    public IBuilder BuildFrame()    
    {
        GameObject go = Utilities.CreateFromSO("Steel Frame");
        _ally.AddComponent(go);
        return this;
    }

    public IBuilder BuildMotor()    
    {
        GameObject go = Utilities.CreateFromSO("Heavy Treads");
        _ally.AddComponent(go);
        return this;
    }

    public IBuilder BuildWeapon()    
    {
        GameObject go = Utilities.CreateFromSO("Mortar");
        _ally.AddComponent(go);
        return this;
    }

    public SupportAlly GetAlly()    
    {
        return _ally;   
    }
}

public class DroneBuilder : IBuilder    
{
    private SupportAlly _ally;    

    public DroneBuilder()    
    {
        _ally = new SupportAlly("Drone");    
    }

    public IBuilder BuildFrame()
    {
        GameObject go = Utilities.CreateFromSO("Titanium Hull");
        _ally.AddComponent(go);
        return this;
    }

    public IBuilder BuildMotor()    
    {
        GameObject go = Utilities.CreateFromSO("Fiberglass Wings");
        _ally.AddComponent(go);
        return this;
    }

    public IBuilder BuildWeapon()    
    {
        GameObject go = Utilities.CreateFromSO("Missiles");
        _ally.AddComponent(go);
        return this;
    }

    public SupportAlly GetAlly()    
    {
        return _ally;    
    }
}
