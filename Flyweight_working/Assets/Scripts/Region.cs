using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Region
{
    public string Name { get; protected set; }
    public List<string> Languages { get; protected set; }

    public abstract void Encode(string dlc);
}

public class US : Region
{
    public override void Encode(string dlc)
    {
        Debug.Log($"");
    }
}

public class Asia : Region
{
    public override void Encode(string dlc)
    {
        throw new System.NotImplementedException();
    }
}

public class Europe : Region
{
    public override void Encode(string dlc)
    {
        throw new System.NotImplementedException();
    }
}