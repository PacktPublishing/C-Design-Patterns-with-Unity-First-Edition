using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text LumberUI;

    private int _lumber = 100;
    public int LumberSupply
    {
        get { return _lumber; }
        set
        {
            if(value > 0)
            {
                _lumber = value;
                LumberUI.text = "Onyx: x" + LumberSupply;
            }
            else
            {
                Debug.Log("You're out of funds...");
            }
        }
    }

    void Awake()
    {
        //CollectableResource.ResourceCollected += ResourceCollected;
        //Consumable.Purchased += ResourceCollected;
    }

    public void ResourceCollected(int cost)
    {
        LumberSupply -= cost;
    }
}