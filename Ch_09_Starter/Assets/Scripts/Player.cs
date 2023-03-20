using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public UIManager uIManager;
    public float moveSpeed = 10f;
    public int health
    {
        get { return _health; }
        set
        {
            _health = value;
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
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.tag == "Health")
        {
            health++;
            Debug.Log("Health collected!");
            Destroy(collision.gameObject);
        }
    }
}