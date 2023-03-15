using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifespan;

    void Awake()    
    {
        lifespan = 0.0f;
    }

    void Update()    
    {
        lifespan += 1.0f;    
    }

    void OnDisable()    
    {
        Debug.Log($"Projectile lifespan -> {lifespan} frames");    
        lifespan = 0.0f;    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Boundary")
        {
            GenericPool.shared.pool.Release(this);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Destroy(collision.gameObject);
            GenericPool.shared.pool.Release(this);
        }
    }
}