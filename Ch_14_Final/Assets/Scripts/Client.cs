using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Client : MonoBehaviour
{
    public TMP_Text GameSaves;
    public Player Originator;
    public Caretaker Caretaker;

    void Awake()
    {
        Caretaker = new Caretaker();
        var mementoData = Originator.NewSave();
        Caretaker.Memento = mementoData;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            Originator.IncreaseDifficulty();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Originator.Restore(Caretaker.Memento);
        }
    }
}