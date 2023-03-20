using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour, IObserver
{
    public Text health;
    private Player _subject;    

    public void NotifiedBy(Subject subject, string eventName)    
    {
        if (!_subject)    
        {
            _subject = subject.GetComponent<Player>();    
        }

        switch (eventName)    
        {
            case "HealthUpdated":   
                health.text = $"Health: {_subject.health}";    
                break;    
            case "PlayerKO":   
                var scene = SceneManager.GetActiveScene().buildIndex;    
                SceneManager.LoadScene(scene);
                Debug.Log("Level restarted...");
                break;
            case "SubjectDestroyed":    
                Debug.Log("Subject has been destroyed...");    
                break;    
        }
    }

    void OnDisable()    
    {
        if (_subject)    
        {
            _subject.RemoveObserver(this);    
            Debug.Log("Observer removed from subject...");    
        }
    }
}