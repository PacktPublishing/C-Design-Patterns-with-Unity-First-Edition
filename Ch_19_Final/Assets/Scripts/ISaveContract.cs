using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaveContract
{
    void Save(string data);
    void Load();
}