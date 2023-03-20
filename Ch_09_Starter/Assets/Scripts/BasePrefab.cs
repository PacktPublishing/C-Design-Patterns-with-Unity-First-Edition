using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePrefab : MonoBehaviour
{
    public float moveSpeed;

    void Awake()
    {
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        rb.velocity = Vector3.left * moveSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            Debug.Log($"{gameObject.tag} destroyed out of bounds...");
            Destroy(this.gameObject);
        }
    }
}