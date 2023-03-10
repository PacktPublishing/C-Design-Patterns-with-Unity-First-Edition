using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Item
{
    void Equip();
}

public class Pebble : MonoBehaviour, Item
{
    public void Equip()
    {
        Debug.Log("You skipped your pebble at a nearby lake.");
    }
}

public class CursedKnife : MonoBehaviour, Item
{
    public void Equip()
    {
        var player = GameObject.FindObjectOfType<Player>();    
        player.SetColor(Color.magenta);    

        Debug.Log($"Woops, you're cursed...");
    }
}

public class Potion : MonoBehaviour, Item    
{
    public void Equip()    
    {
        var player = GameObject.FindObjectOfType<Player>();    
        player.SetColor(Color.green);    

        var manager = GameObject.FindObjectOfType<Manager>();    
        manager.HP += 5;    
        manager.Boost++;    

        Debug.Log($"Potion healed you for 5 HP!");    
    }
}