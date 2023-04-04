using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour, IElement
{
    public string Name;
    public int Damage;
    public int Critical;

    public List<IElement> _modifications = new List<IElement>()
    {
        new WeaponMod("Critical buff", 1),
        new WeaponMod("Stamina recovery", 2)
    };

    public void Accept(IVisitor visitor)
    {
        foreach (var mod in _modifications)
        {
            mod.Accept(visitor);
        }

        visitor.VisitWeapon(this);
    }
}

public class WeaponMod : IElement
{
    public string Name;
    public int Slot;
    public int Level = 1;

    public WeaponMod(string name, int slot)
    {
        this.Name = name;
        this.Slot = slot;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitWeaponMod(this);
    }
}