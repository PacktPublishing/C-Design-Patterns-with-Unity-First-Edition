using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Upgrade", menuName = "SOVisitor")]
public class SOVisitor : ScriptableObject, IVisitor
{
    public int StatsBoost;
    public int DamageBoost;
    public int CriticalBoost;
    public bool UpgradeMod;

    public void VisitStats(Stats stats)
    {
        if (StatsBoost == 0)
            return;

        stats.Intelligence += StatsBoost;
        stats.Strength += StatsBoost;

        Debug.LogFormat($"Intelligence -> {stats.Intelligence}, Strength -> {stats.Strength}");
    }

    public void VisitWeapon(Weapon weapon)
    {
        if (DamageBoost > 0)
        {
            weapon.Damage += DamageBoost;
            Debug.LogFormat($"Damage increased -> {weapon.Damage}");
        }

        if (CriticalBoost > 0)
        {
            weapon.Critical *= CriticalBoost;
            Debug.LogFormat($"Critical increased -> {weapon.Critical}");
        }
    }

    public void VisitWeaponMod(WeaponMod mod)
    {
        if (UpgradeMod == false)
            return;

        mod.Level++;
        Debug.LogFormat($"{mod.Name} level -> {mod.Level}");
    }
}