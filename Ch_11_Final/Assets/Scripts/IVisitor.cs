using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVisitor
{
    void VisitStats(Stats stats);
    void VisitWeapon(Weapon weapon);
    void VisitWeaponMod(WeaponMod mod);
}