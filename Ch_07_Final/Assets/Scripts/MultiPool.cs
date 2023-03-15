using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoolData
{
    public string tag;
    public GameObject obj;
    public int size;
}

public class MultiPool : MonoBehaviour
{
    public List<PoolData> pools = new List<PoolData>();
    public Dictionary<string, Queue<GameObject>> poolCollection;

    void Start()
    {
        poolCollection = new Dictionary<string, Queue<GameObject>>();

        foreach (PoolData data in pools)
        {
            CreateObject(data);
        }
    }

    void CreateObject(PoolData data)
    {
        var parent = new GameObject($"{data.tag}'s");
        parent.transform.SetParent(this.transform);

        Queue<GameObject> newPool = new Queue<GameObject>();

        for (int i = 0; i < data.size; i++)
        {
            GameObject newObject = Instantiate(data.obj);
            newObject.SetActive(false);
            newObject.transform.SetParent(parent.transform);
            newPool.Enqueue(newObject);
        }

        poolCollection.Add(data.tag, newPool);
    }
}