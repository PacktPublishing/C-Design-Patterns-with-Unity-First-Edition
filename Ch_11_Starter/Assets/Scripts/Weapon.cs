using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string Name;
    public int Damage;
    public int Critical;

    public List<WeaponMod> _modifications = new List<WeaponMod>()
    {
        new WeaponMod("Critical buff", 1),
        new WeaponMod("Stamina recovery", 2)
    };
}

public class WeaponMod
{
    public string Name;
    public int Slot;
    public int Level = 1;

    public WeaponMod(string name, int slot)
    {
        this.Name = name;
        this.Slot = slot;
    }
}