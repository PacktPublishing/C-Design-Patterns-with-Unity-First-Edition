using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IForge
{
    public void Craft();
    public void Disassemble();
}

public interface IMerchant
{
    public void Buy();
    public void Sell();
}

public class BlacksmithForge : IForge
{
    public void Craft()
    {
        Debug.Log("Your item was created from raw materials!");
    }

    public void Disassemble()
    {
        Debug.Log("Item was broken down to its raw materials.");
    }
}

public class FusionForge : IForge
{
    public void Craft()
    {
        Debug.Log("Your items were fused together!");
    }

    public void Disassemble()
    {
        Debug.Log("Fused item was returned to rare materials.");
    }
}

public class BlacksmithMerchant : IMerchant
{
    public void Buy()
    {
        Debug.Log("Thanks for paying in gold!");
    }

    public void Sell()
    {
        Debug.Log("Would you accept gold for that item?");
    }
}

public class FusionMerchant : IMerchant
{
    public void Buy()
    {
        Debug.Log("We only accept soul chips for fusions.");
    }

    public void Sell()
    {
        Debug.Log("We can only pay you in soul chips.");
    }
}

public interface IAbstractFactory
{
    public IForge CreateForgeSystem();
    public IMerchant CreateMerchantSystem();
}

public class BlacksmithFactory : IAbstractFactory
{
    public IForge CreateForgeSystem()
    {
        return new BlacksmithForge();
    }

    public IMerchant CreateMerchantSystem()
    {
        return new BlacksmithMerchant();
    }
}

public class FusionFactory : IAbstractFactory
{
    public IForge CreateForgeSystem()
    {
        return new FusionForge();
    }

    public IMerchant CreateMerchantSystem()
    {
        return new FusionMerchant();
    }
}