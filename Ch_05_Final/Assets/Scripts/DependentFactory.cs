using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UpgradeMaterial { }
public class Iron : UpgradeMaterial { }
public class Dragonscale : UpgradeMaterial { }

public abstract class Item
{
    public abstract void Upgrade(UpgradeMaterial material);
}

public class Sword : Item
{
    public override void Upgrade(UpgradeMaterial material)
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
    public override void Upgrade(UpgradeMaterial material)
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
    public abstract UpgradeMaterial GetMaterial();
}

public class IronSwordUpgrade : AbstractRecipeFactory
{
    public override UpgradeMaterial GetMaterial()
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
    public override UpgradeMaterial GetMaterial()
    {
        return new Dragonscale();
    }

    public override Item GetItem()
    {
        return new Lance();
    }
}