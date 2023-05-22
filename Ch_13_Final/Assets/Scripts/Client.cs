using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    void Start()
    {
        var zombieType = new Monster.MonsterType(null, 100, 1, 20, "Brains!");
        var ghoul = zombieType.CreateMonster("Ghoul");
        var undeadMage = zombieType.CreateMonster("Undead Mage");
        ghoul.PrintStats();
        undeadMage.PrintStats();

        var zombieBoss = new Monster.MonsterType(zombieType, 120, 10, 0, null);
        var megaZombie = zombieBoss.CreateMonster("Boss Zombie!");
        megaZombie.PrintStats();
    }
}