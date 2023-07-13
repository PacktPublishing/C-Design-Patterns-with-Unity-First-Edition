using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSpawner : MonoBehaviour
{
    void Start()
    {
        //Enemy ogre = new Enemy(10, "RAWR", "Ogre", new Item("Poison dart"));
        //ogre.Print();

        //IPrototype clonedPrototype = ogre.DeepClone();
        //if (clonedPrototype is Enemy clonedEnemy)
        //{
        //    clonedEnemy.Print();

        //    ogre.Name = "Monstrous Ogre";
        //    ogre.Damage = 30;
        //    ogre.Item.Name = "Potion";
        //    ogre.Print();
        //    clonedEnemy.Print();
        //}
        //else
        //{
        //    Debug.Log("Failed to clone ogre. Cloned object is not an Enemy...");
        //}

        Factory<IPrototype> factory = new Factory<IPrototype>();
        factory["Ogre"] = new Enemy(10, "RAWR", "Ogre", new Item("Poison dart"));
        factory["Knight"] = new Enemy(15, "To Arms!", "Ash Knight", new Item("Shuriken"));

        IPrototype ogrePrototype = (Enemy)factory["Ogre"].DeepClone();
        IPrototype knightPrototye = (Enemy)factory["Knight"].DeepClone();

        if(ogrePrototype is Enemy ogreEnemy)
        {
            ogreEnemy.Print();
        }

        if(knightPrototye is Enemy knightEnemy)
        {
            knightEnemy.Print();
        }
    }
}