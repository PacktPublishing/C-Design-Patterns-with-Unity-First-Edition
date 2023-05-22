using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum Size { Large, Medium, Small }

public abstract class Consumable
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }

    public virtual void Buy(Size size, int cost)
    {
        Debug.Log($"{size} {Name} bought for {cost} magic beans!");
    }
}

public class Potion : Consumable
{
    public Potion()
    {
        Name = "Potion";
        Description = "A healthy dose of HP";
    }
}

public class Antidote : Consumable
{
    public Antidote()
    {
        Name = "Antidote";
        Description = "A healing salve for poisons and punctures";
    }
}

public class ItemFactory
{
    private Dictionary<string, Consumable> _cache = new Dictionary<string, Consumable>();
    public int ItemsCreated { get { return _cache.Count; } }

    public Consumable GetItem(string name)
    {
        Consumable item = null;

        if (_cache.ContainsKey(name))
        {
            Debug.LogFormat($"Reusing {name} object...");
            item = _cache[name];
        }
        else
        {
            Debug.LogFormat($"Creating new {name} Flyweight...");
            switch (name)
            {
                case "Potion":
                    item = new Potion();
                    break;
                case "Antidote":
                    item = new Antidote();
                    break;
            }

            _cache.Add(name, item);
        }

        return item;
    }
}