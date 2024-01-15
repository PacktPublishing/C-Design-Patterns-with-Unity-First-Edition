using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int lifespan;

    void Update()    
    {
        lifespan += 1;    
    }

    public void Reset()
    {
        Debug.Log($"Projectile lifespan -> {lifespan} frames");
        lifespan = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Boundary")
        {
            GenericPool.Shared.Pool.Release(this);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Destroy(collision.gameObject);
            GenericPool.Shared.Pool.Release(this);
        }
    }
}