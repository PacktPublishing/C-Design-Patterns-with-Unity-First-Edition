using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text ActionBindings;

    public void AddKeyBinding(string key, string commandName)
    {
        var command = commandName.Substring(0, commandName.Length - 7);
        ActionBindings.text += $"{key} --> {command}\n\n";
    }
}