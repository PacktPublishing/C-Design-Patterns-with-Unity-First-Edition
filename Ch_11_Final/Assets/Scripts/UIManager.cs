using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text StatsUI;
    public TMP_Text WeaponUI;

    public Stats Stats;
    public Weapon Weapon;

    // Update is called once per frame
    void Update()
    {
        StatsUI.text = $"Int: {Stats.Intelligence}  Str: {Stats.Strength}";
        WeaponUI.text = $"Dmg: {Weapon.Damage}  Crit: {Weapon.Critical}";
    }
}