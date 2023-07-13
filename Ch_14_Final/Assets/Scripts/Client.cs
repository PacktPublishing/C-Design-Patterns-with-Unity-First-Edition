using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Slider HPSlider;
    public Slider MPSlider;
    public Slider INTSlider;
    public Character _originator;

    private Caretaker _caretaker;

    void Awake()
    {
        _caretaker = new Caretaker(_originator);
        Save();
    }

    public void Save()
    {
        _caretaker.Save();
    }

    public void Restore()
    {
        _caretaker.RestoreLast();

        HPSlider.value = _originator.HP;
        MPSlider.value = _originator.MP;
        INTSlider.value = _originator.INT;
    }
}