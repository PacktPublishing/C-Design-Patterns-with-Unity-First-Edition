using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    public T Copy<T>() where T : Component
    {
        Clone instance = Instantiate(this);
        GameObject spawner = GameObject.Find("Enemy Spawner");
        var enemyRange = new Vector3(Random.Range(-7, 7), 0, Random.Range(-7, 7));

        instance.transform.SetParent(spawner.transform);
        instance.transform.localPosition = enemyRange;

        return instance.GetComponent<T>();
    }
}