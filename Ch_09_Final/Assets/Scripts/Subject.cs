using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour    
{
    private List<IObserver> _observers = new List<IObserver>();    

    public void AddObserver(IObserver observer)    
    {
        _observers.Add(observer);    
    }

    public void RemoveObserver(IObserver observer)    
    {
        _observers.Remove(observer);    
    }

    public void NotifyAll(string eventName)    
    {
        foreach (var observer in _observers)    
        {
            observer.NotifiedBy(this, eventName);    
        }
    }

    void OnDisable()    
    {
        NotifyAll("SubjectDestroyed");    
    }
}