using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCreator
{
    public GameObject Spawner { get; protected set; }
    public GameObject Model { get; protected set; }

    public AbstractCreator(GameObject model)
    {
        Spawner = new GameObject();
        Model = model;
    }

    public abstract Item Create();
}

public class PebbleFactory : AbstractCreator
{
    public PebbleFactory(GameObject model) : base(model)
    {
        Spawner.name = "Pebble Factory";
    }

    public override Item Create()
    {
        var pebble = GameObject.Instantiate(Model);
        pebble.AddComponent<Pebble>();
        pebble.transform.position = new Vector3(-2.2f, 0.3f, -7f);
        pebble.transform.SetParent(Spawner.transform);

        return pebble.GetComponent<Pebble>();
    }
}

public class CursedKnifeFactory : AbstractCreator
{
    public CursedKnifeFactory(GameObject model) : base(model)
    {
        Spawner.name = "Cursed Knife Factory";
    }

    public override Item Create()    
    {
        var knife = GameObject.Instantiate(Model);
        knife.AddComponent<CursedKnife>();
        knife.transform.position = new Vector3(-0.6f, 0.3f, -7.6f);
        knife.transform.SetParent(Spawner.transform);

        return knife.GetComponent<CursedKnife>();
    }
}

public class PotionFactory : AbstractCreator
{
    public PotionFactory(GameObject model) : base(model)
    {
        Spawner.name = "Potion Factory";
    }

    public override Item Create()    
    {
        var potion = GameObject.Instantiate(Model);
        potion.AddComponent<Potion>();
        potion.transform.position = new Vector3(0.6f, 0.3f, -7f);
        potion.transform.SetParent(Spawner.transform);

        return potion.GetComponent<Potion>();
    }
}