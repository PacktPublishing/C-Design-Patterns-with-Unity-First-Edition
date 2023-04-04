using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    public static void PrintPlayerPrefs()
    {
        int intelligence = PlayerPrefs.GetInt("_intelligence");
        int strength = PlayerPrefs.GetInt("_strength");

        string weaponName = PlayerPrefs.GetString("_weaponName");
        int weaponDamage = PlayerPrefs.GetInt("_weaponDamage");
        int weaponCritical = PlayerPrefs.GetInt("_weaponCritical");

        string weaponMod1 = PlayerPrefs.GetString("_weaponMod1");
        string weaponMod2 = PlayerPrefs.GetString("_weaponMod2");

        Debug.LogFormat($"Character Data: \n " +
                            $"\tIntelligence: {intelligence} \n" +
                            $"\tStrength: {strength} \n" +
                            $"\tWeapon Name: {weaponName}\n" +
                            $"\tWeapon Damage: {weaponDamage}\n" +
                            $"\tWeapon Critical: {weaponCritical} \n" +
                            $"\tMod Slot 1: {weaponMod1}\n" +
                            $"\tMod Slot 2: {weaponMod2}\n");
    }
}