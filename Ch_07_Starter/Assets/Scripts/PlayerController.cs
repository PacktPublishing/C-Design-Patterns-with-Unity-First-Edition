using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public GameObject bulletPrefab;
    public float bulletSpeed = 100f;

    private float _horizontalInput;
    private Rigidbody _rb;
    private bool _isShooting;

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal") * moveSpeed;
        _isShooting |= Input.GetKey(KeyCode.Space);
    }

    void FixedUpdate()
    {
        if(_isShooting)
        {
            CreateBullet();
        }

        Move();

        _isShooting = false;
    }

    void CreateBullet()
    {
        GameObject newBullet = Instantiate(bulletPrefab, this.transform.position + Vector3.zero , this.transform.rotation);
        Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();
        bulletRB.velocity = this.transform.forward * bulletSpeed;
    }

    void Move()
    {
        _rb.MovePosition(this.transform.position + this.transform.right * _horizontalInput * Time.fixedDeltaTime);
    }
}