using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public BaseEnemy OgrePrefab;
    public BaseEnemy AshKnightPrefab;
    private Factory<ICopy> factory = new Factory<ICopy>();

    void Awake()
    {
        factory["Ogre"] = OgrePrefab;
        factory["Knight"] = AshKnightPrefab;
    }

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            BaseEnemy clone = null;
            var random = Random.Range(1, 3);

            switch (random)
            {
                case 1:
                    clone = (BaseEnemy)factory["Ogre"].Copy(this.transform);
                    break;
                case 2:
                    clone = (BaseEnemy)factory["Knight"].Copy(this.transform);
                    break;
            }

            if(clone)
            {
                clone.Attack();
            }
        }
    }
}