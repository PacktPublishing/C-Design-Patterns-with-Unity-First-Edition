using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    private string _name;
    private int _level;
    private int _hp;
    private int _toughness;
    private string _warCry;

    public void PrintStats()
    {
        var stats = $"Level {_level} {_name}:\n";
        stats += $"\t-> HP: {_hp}\n";
        stats += $"\t-> Toughness: {_toughness}\n";
        stats += $"\t-> War Cry: {_warCry}";

        Debug.Log(stats);
    }
}