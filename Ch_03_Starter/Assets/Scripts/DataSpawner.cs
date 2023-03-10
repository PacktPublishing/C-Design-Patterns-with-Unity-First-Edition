using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSpawner : MonoBehaviour
{
    void Start()
    {
        Enemy ogre = new Enemy(10, "RAWR", "Ogre");
        ogre.Print();
    }
}