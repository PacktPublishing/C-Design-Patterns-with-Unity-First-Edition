using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text HPField;
    public Text BoostField;

    private int _hp = 10;
    public int HP
    {
        get { return _hp; }
        set
        {
            _hp = value;
            HPField.text = $"HP: {value}";
        }
    }

    private int _boost = 0;
    public int Boost
    {
        get { return _boost; }
        set
        {
            _boost = value;
            BoostField.text = $"Boost: {value}x";
        }
    }
}