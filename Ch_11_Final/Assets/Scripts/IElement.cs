using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IElement
{
    void Accept(IVisitor visitor);
}