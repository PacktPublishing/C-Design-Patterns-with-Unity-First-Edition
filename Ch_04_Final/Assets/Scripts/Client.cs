using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public ItemButton ButtonPrefab;

    public GameObject PebbleModel;   
    public GameObject KnifeModel;   
    public GameObject PotionModel;

    void Start()
    {
        List<Vector3> pos = new List<Vector3>()
        {
            new Vector3(-2.2f, 0.3f, -7f),
            new Vector3(-0.6f, 0.3f, -7.6f),
            new Vector3(0.6f, 0.3f, -7f)
        };

        var itemFactory = new ReflectionFactory();

        List<Item> items = new List<Item>()    
        {
            itemFactory.Create("Pebble", PebbleModel, pos[0]),
            itemFactory.Create("CursedKnife", KnifeModel, pos[1]),
            itemFactory.Create("Potion", PotionModel, pos[2])   
        };

        foreach (Item item in items)    
        {
            var button = Instantiate(ButtonPrefab);    

            button.Configure(item);    
            button.transform.SetParent(this.transform);    
        }
    }
}