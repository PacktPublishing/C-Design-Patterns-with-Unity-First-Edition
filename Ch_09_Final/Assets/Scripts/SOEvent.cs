using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/SO Event")]    
public class SOEvent : ScriptableObject    
{
    private List<SOListener> _subscribers = new List<SOListener>();    

    public void NotifyAll()    
    {
        for (int i = _subscribers.Count - 1; i >= 0; i--)    
        {
            _subscribers[i].OnEventInvoked();    
        }
    }

    public void Subscribe(SOListener listener)    
    {
        if (!_subscribers.Contains(listener))    
        {
            _subscribers.Add(listener);    
        }
    }

    public void Unsubscribe(SOListener listener)    
    {
        if (_subscribers.Contains(listener))    
        {
            _subscribers.Remove(listener);    
        }
    }
}