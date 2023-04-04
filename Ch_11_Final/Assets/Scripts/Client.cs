using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Player Player;
    private IVisitor _visitor;

    void Start()
    {
        _visitor = new PlayerPrefVisitor();
    }

    public void SaveData()
    {
        Player.Accept(_visitor);
        Utilities.PrintPlayerPrefs();
    }
}