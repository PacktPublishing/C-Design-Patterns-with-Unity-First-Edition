using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public List<UnitController> units = new List<UnitController>();
    public int unitIndex = 0;

    public UnitController unit
    {
        get
        {
            return units[unitIndex];
        }
    }
}