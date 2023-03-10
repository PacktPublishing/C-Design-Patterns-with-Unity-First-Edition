using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Material { }
public class Iron : Material { }
public class Dragonscale : Material { }

public abstract class Item
{
    public abstract void Upgrade(Material material);
}

public class Sword : Item
{
    public override void Upgrade(Material material)
    {
        if (material.GetType().Name == "Iron")
        {
            Debug.Log("Sword upgraded => Iron Sword!");
        }
        else
        {
            Debug.Log("You don't have the right upgrade materials.");
        }
    }
}

public class Lance : Item
{
    public override void Upgrade(Material material)
    {
        if (material.GetType().Name == "Dragonscale")
        {
            Debug.Log("Lance upgraded => Dragonite Lance!");
        }
        else
        {
            Debug.Log("You don't have the right upgrade materials.");
        }
    }
}

public abstract class AbstractRecipeFactory
{
    public abstract Item GetItem();
    public abstract Material GetMaterial();
}

public class IronSwordUpgrade : AbstractRecipeFactory
{
    public override Material GetMaterial()
    {
        return new Iron();
    }

    public override Item GetItem()
    {
        return new Sword();
    }
}

public class DragoniteLanceUpgrade : AbstractRecipeFactory
{
    public override Material GetMaterial()
    {
        return new Dragonscale();
    }

    public override Item GetItem()
    {
        return new Lance();
    }
}