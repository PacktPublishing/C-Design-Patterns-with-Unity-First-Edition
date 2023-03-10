using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client
{
    private AbstractRecipeFactory factory;    

    public Client(AbstractRecipeFactory factory)    
    {
        this.factory = factory;    
    }

    public void ExecuteFactoryProcesses()    
    {
        var item = factory.GetItem();    
        var material = factory.GetMaterial();

        item.Upgrade(material);    
    }
}