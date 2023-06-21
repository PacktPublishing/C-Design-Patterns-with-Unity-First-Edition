using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    private float _horInput;
    private float _vertInput;
    private bool _isJumping;
    private Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _horInput = Input.GetAxis("Vertical") * moveSpeed;
        _vertInput = Input.GetAxis("Horizontal") * rotateSpeed;
        _isJumping |= Input.GetKeyDown(KeyCode.Space);

        this.transform.Translate(Vector3.forward * _horInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * _vertInput * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (_isJumping)
        {
            _rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

        _isJumping = false;
    }
}