using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentSpawner : MonoBehaviour
{
    public Clone OgrePrefab;
    public Clone AshKnightPrefab;
    private Factory<Clone> factory = new Factory<Clone>();

    void Awake()
    {
        factory["Ogre"] = OgrePrefab;
        factory["Knight"] = AshKnightPrefab;
    }

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            BaseEnemy clonedEnemy = null;
            var random = Random.Range(1, 3);
            switch (random)
            {
                case 1:
                    clonedEnemy = factory["Ogre"].Copy<Ogre>();
                    break;
                case 2:
                    clonedEnemy = factory["Knight"].Copy<AshKnight>();
                    break;
            }

            clonedEnemy.Attack();
        }
    }
}