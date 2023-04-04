using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(Stats))]
[RequireComponent(typeof(Weapon))]
public class Player : MonoBehaviour
{
    private List<IElement> _elements = new List<IElement>();

    void Start()
    {
        _elements.Add(this.gameObject.GetComponent<Stats>());
        _elements.Add(this.gameObject.GetComponent<Weapon>());
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var element in _elements)
        {
            element.Accept(visitor);
        }
    }
}