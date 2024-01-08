using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterizedCreator    
{
    public virtual IItem Create(string itemName)    
    {
        switch (itemName)    
        {
            case "Normal":    
                return new Pebble();
            case "Rare":    
                return new CursedKnife();
            default:
                return null;
        }
    }
}

public class NoobFactory : ParameterizedCreator    
{
    public override IItem Create(string itemName)    
    {
        switch (itemName)    
        {
            case "Rare":    
                return new Pebble();    
            case "Healing":    
                return new Pebble();    
        }

        return base.Create(itemName);    
    }
}