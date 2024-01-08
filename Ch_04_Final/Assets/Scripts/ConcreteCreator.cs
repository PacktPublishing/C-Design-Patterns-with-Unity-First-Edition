using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteCreator    
{
    public GameObject Spawner { get; protected set; }

    public GameObject PebbleModel { get; protected set; }
    public GameObject KnifeModel { get; protected set; }
    public GameObject PotionModel { get; protected set; }

    protected List<IItem> _items = new List<IItem>();
    public List<IItem> Items
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

    public virtual IItem NormalItem()    
    {
        var pebble = GameObject.Instantiate(PebbleModel);
        var item = pebble.AddComponent<Pebble>();

        pebble.transform.position = new Vector3(-2.2f, 0.3f, -7f);
        pebble.transform.SetParent(Spawner.transform);
        _items.Add(item);

        return pebble.GetComponent<Pebble>();
    }

    public virtual IItem RareItem()    
    {
        var knife = GameObject.Instantiate(KnifeModel);
        var item = knife.AddComponent<CursedKnife>();

        knife.transform.position = new Vector3(-0.6f, 0.3f, -7.6f);
        knife.transform.SetParent(Spawner.transform);
        _items.Add(item);

        return knife.GetComponent<CursedKnife>();
    }

    public virtual IItem HealingItem()    
    {
        var potion = GameObject.Instantiate(PotionModel);
        var item = potion.AddComponent<Potion>();

        potion.transform.position = new Vector3(0.6f, 0.3f, -7f);
        potion.transform.SetParent(Spawner.transform);
        _items.Add(item);

        return potion.GetComponent<Potion>();
    }

    public List<IItem> CreateInventory()    
    {
        return new List<IItem>()   
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
