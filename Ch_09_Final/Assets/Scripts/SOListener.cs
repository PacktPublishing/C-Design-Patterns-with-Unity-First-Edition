using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;    

public class SOListener : MonoBehaviour    
{
    public SOEvent subjectEvent;    
    public UnityEvent response;    

    public void OnEnable()    
    {
        if (subjectEvent != null)    
        {
            subjectEvent.Subscribe(this);    
        }
    }

    public void OnEventInvoked()    
    {
        response?.Invoke();    
    }

    public void OnDisable()    
    {
        subjectEvent.Unsubscribe(this);    
    }
}