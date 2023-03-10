using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public void Configure(Item item)
    {
        this.gameObject.name = $"{item.GetType().Name} (UI)";

        var button = GetComponent<Button>();
        button.onClick.AddListener(item.Equip);

        var text = GetComponentInChildren<Text>();
        text.text = $"{item.GetType().Name} (Item)";
    }
}