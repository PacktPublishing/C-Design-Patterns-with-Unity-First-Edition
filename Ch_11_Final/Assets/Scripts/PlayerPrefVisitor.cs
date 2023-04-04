using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefVisitor : IVisitor
{
    public void VisitStats(Stats stats)
    {
        PlayerPrefs.SetInt("_intelligence", stats.Intelligence);
        PlayerPrefs.SetInt("_strength", stats.Strength);
    }

    public void VisitWeapon(Weapon weapon)
    {
        PlayerPrefs.SetString("_weaponName", weapon.Name);
        PlayerPrefs.SetInt("_weaponDamage", weapon.Damage);
        PlayerPrefs.SetInt("_weaponCritical", weapon.Critical);
    }

    public void VisitWeaponMod(WeaponMod mod)
    {
        PlayerPrefs.SetString("_weaponMod" + mod.Slot, mod.Name);
    }
}