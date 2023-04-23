using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SOStrategy : ScriptableObject
{
    public abstract void Think();
    public abstract void React(BehaviorContext context);
}