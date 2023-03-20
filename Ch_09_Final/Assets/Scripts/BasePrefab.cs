using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BasePrefab : MonoBehaviour
{
    public float moveSpeed;

    public delegate void HealthDestroyed();    
    public static event HealthDestroyed OnHealthDestroyed;

    public static event Action OnEnemyDestroyed;

    void Awake()
    {
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        rb.velocity = Vector3.left * moveSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            if (gameObject.tag == "Health")    
            {
                OnHealthDestroyed?.Invoke();    
            }
            else    
            {
                OnEnemyDestroyed?.Invoke();    
            }

            Debug.Log($"{gameObject.tag} destroyed out of bounds...");
            Destroy(this.gameObject);
        }
    }
}