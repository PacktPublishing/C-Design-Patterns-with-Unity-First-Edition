using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSpawner : MonoBehaviour
{
    void Start()
    {
        //Enemy ogre = new Enemy(10, "RAWR", "Ogre", new Item("Poison dart"));
        //ogre.Print();

        //var clonedEnemy = (Enemy)ogre.DeepClone();
        //clonedEnemy.Print();

        //ogre.Name = "Monstrous Ogre";
        //ogre.Damage = 30;
        //ogre.Item.Name = "Potion";
        //ogre.Print();
        //clonedEnemy.Print();

        Factory<IPrototype> factory = new Factory<IPrototype>();
        factory["Ogre"] = new Enemy(10, "RAWR", "Ogre", new Item("Poison dart"));
        factory["Knight"] = new Enemy(15, "To Arms!", "Ash Knight", new Item("Shuriken"));

        var clonedOgre = (Enemy)factory["Ogre"].DeepClone();
        var clonedKnight = (Enemy)factory["Knight"].DeepClone();

        clonedOgre.Print();
        clonedKnight.Print();
    }
}