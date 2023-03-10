using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteCreator    
{
    public GameObject Spawner { get; protected set; }

    public GameObject PebbleModel { get; protected set; }
    public GameObject KnifeModel { get; protected set; }
    public GameObject PotionModel { get; protected set; }

    protected List<Item> _items = new List<Item>();
    public List<Item> Items
    {
        get { return _items; }
    }

    public ConcreteCreator()
    {
        Spawner = new GameObject();
        Spawner.name = "Concrete Factory";

        PebbleModel = Resources.Load("Pebble") as GameObject;
        KnifeModel = Resources.Load("Knife") as GameObject;
        PotionModel = Resources.Load("Potion") as GameObject;

        CreateInventory();
    }

    public virtual Item NormalItem()    
    {
        var pebble = GameObject.Instantiate(PebbleModel);
        var item = pebble.AddComponent<Pebble>();

        pebble.transform.position = new Vector3(-2.2f, 0.3f, -7f);
        pebble.transform.SetParent(Spawner.transform);
        _items.Add(item);

        return pebble.GetComponent<Pebble>();
    }

    public virtual Item RareItem()    
    {
        var knife = GameObject.Instantiate(KnifeModel);
        var item = knife.AddComponent<CursedKnife>();

        knife.transform.position = new Vector3(-0.6f, 0.3f, -7.6f);
        knife.transform.SetParent(Spawner.transform);
        _items.Add(item);

        return knife.GetComponent<CursedKnife>();
    }

    public virtual Item HealingItem()    
    {
        var potion = GameObject.Instantiate(PotionModel);
        var item = potion.AddComponent<Potion>();

        potion.transform.position = new Vector3(0.6f, 0.3f, -7f);
        potion.transform.SetParent(Spawner.transform);
        _items.Add(item);

        return potion.GetComponent<Potion>();
    }

    public List<Item> CreateInventory()    
    {
        return new List<Item>()   
        {
            NormalItem(),
            RareItem(),
            HealingItem(),
        };
    }
}

//public class HealingFactory : ConcreteCreator    
//{
//    public override Item NormalItem()    
//    {
//        return new Potion();    
//    }

//    public override Item RareItem()    
//    {
//        return new Potion();    
//    }
//}
