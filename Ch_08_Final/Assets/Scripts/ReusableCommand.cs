using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ReusableCommand    
{
    public abstract void Execute(UnitController receiver);    
}

public class ShootCommand : ReusableCommand    
{
    public override void Execute(UnitController receiver)   
    {
        Debug.Log("Shoot command executed...");
        receiver.Shoot();
    }
}

public class MeleeCommand : ReusableCommand    
{
    public override void Execute(UnitController receiver)    
    {
        Debug.Log("Melee command executed...");
        receiver.Melee();
    }
}

public class BlockCommand : ReusableCommand   
{
    public override void Execute(UnitController receiver)    
    {
        Debug.Log("Block command executed...");
        receiver.Block();
    }
}