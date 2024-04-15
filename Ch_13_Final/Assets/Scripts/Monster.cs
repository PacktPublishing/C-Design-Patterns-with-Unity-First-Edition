using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    private MonsterType _monsterType;

    private string _name;
    private int _level;
    private int _hp;
    private int _toughness;
    private string _warCry;

    private Monster(MonsterType type, string name)
    {
        _monsterType = type;
        _name = name;

        _level = type.Level;
        _hp = type.HP;
        _toughness = type.Toughness;
        _warCry = type.WarCry;
    }

    public void PrintStats()
    {
        var stats = $"Level {_level} {_name}:\n";
        stats += $"\t-> HP: {_hp}\n";
        stats += $"\t-> Toughness: {_toughness}\n";
        stats += $"\t-> War Cry: {_warCry}\n";

        Debug.Log(stats);
    }

    public class MonsterType
    {
        public int HP { get; private set; }
        public int Level { get; private set; }
        public int Toughness { get; private set; }
        public string WarCry { get; private set; }

        public MonsterType(MonsterType baseType, int hp, int level, int toughness, string warCry)
        {
            HP = hp;
            Level = level;
            Toughness = toughness;
            WarCry = warCry;

            if(baseType != null)
            {
                if (hp == 0)
                    HP = baseType.HP;
                if (level == 0)
                    Level = baseType.Level;
                if (toughness == 0)
                    Toughness = baseType.Toughness;
                if (warCry == null)
                    WarCry = baseType.WarCry;
            }
        }

        public Monster CreateMonster(string name)
        {
            return new Monster(this, name);
        }
    }
}