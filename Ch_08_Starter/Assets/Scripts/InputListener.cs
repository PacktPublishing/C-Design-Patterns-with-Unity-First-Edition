using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    public UIManager UI;
    private UnitController _unitController;

    void Start()
    {
        _unitController = this.GetComponent<UnitController>();
    }
}