using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Client : MonoBehaviour
{
    public TMP_Text attack;
    public CharacterBehavior Character;

    void Start()
    {
        UpdateUI();
    }

    public void Decorate()
    {
        Character.Decorate();
        UpdateUI();
    }

    public void Battle()
    {
        Character.Battle();
    }

    public void Reset()
    {
        Character.Reset();
        UpdateUI();
    }

    void UpdateUI()
    {
        attack.text = "Attack:";
    }
}