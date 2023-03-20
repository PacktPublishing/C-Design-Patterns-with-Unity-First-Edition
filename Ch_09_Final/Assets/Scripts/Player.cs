using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[Serializable]   
public class CustomStringEvent : UnityEvent<string> { }

public class Player : Subject
{
    public SOEvent OnPlayerDamaged;

    public UIManager uiManager;
    public float moveSpeed = 10f;
    public int health
    {
        get { return _health; }
        set
        {
            if (value == 0)    
            {
                NotifyAll("PlayerKO");   
            }
            else if (value <= 10)    
            {
                _health = value;
                NotifyAll("HealthUpdated");
            }
            else   
            {
                Debug.Log("Health already full!");    
            }
        }
    }

    private int _health = 10;
    private float _horInput;
    private Rigidbody _rb;

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        _horInput = Input.GetAxis("Horizontal") * moveSpeed;
    }

    void FixedUpdate()
    {
        _rb.MovePosition(transform.position + Vector3.back * _horInput * Time.fixedDeltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            health--;
            Debug.Log("Player damaged!");
            OnPlayerDamaged.NotifyAll();
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.tag == "Health")
        {
            health++;
            Debug.Log("Health collected!");
            Destroy(collision.gameObject);
        }
    }

    void OnEnable()    
    {
        AddObserver(uiManager);
    }
}