using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver    
{
    void NotifiedBy(Subject subject, string eventName);    
}