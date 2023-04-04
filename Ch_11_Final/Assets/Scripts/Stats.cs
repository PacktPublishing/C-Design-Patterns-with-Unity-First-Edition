using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour, IElement
{
    public int Intelligence;
    public int Strength;

    public void Accept(IVisitor visitor)
    {
        visitor.VisitStats(this);
    }
}