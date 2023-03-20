using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> prefabs;
    public float spawnInterval = 2f;

    private Vector3 _position;

    void Awake()
    {
        _position = this.transform.position;
    }

    void Update()
    {
        spawnInterval -= Time.deltaTime;

        if (spawnInterval <= 0f)
        {
            var random = Random.Range(0, 2);
            var prefab = Instantiate(prefabs[random], new Vector3(_position.x, _position.y, Random.Range(-4, 4)), transform.rotation);
            spawnInterval = 2f;
        }
    }
}