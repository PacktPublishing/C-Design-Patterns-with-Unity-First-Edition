using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public virtual IEnumerator Enter()
    {
        yield break;
    }

    public virtual void HandleInput() { }
    public virtual void CheckState() { }

    public virtual IEnumerator Exit()
    {
        yield break;
    }
}