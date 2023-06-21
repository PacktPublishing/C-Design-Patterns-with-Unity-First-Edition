using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    [NonSerialized]
    public float moveSpeed = 10f;
    [NonSerialized]
    public float rotateSpeed = 75f;

    private int _level = 1;
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

        transform.Translate(Vector3.forward * _horInput * Time.deltaTime);
        transform.Rotate(Vector3.up * _vertInput * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (_isJumping)
        {
            _rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

        _isJumping = false;
    }

    public void IncreaseDifficulty()
    {
        _level += 1;
        moveSpeed += 2;
        rotateSpeed += 10;
        Debug.Log("Difficulty increased!");
        Debug.Log(_level);
    }

    public SaveMemento NewSave()
    {
        Debug.Log("Creating new save data...");
        Debug.Log(_level);
        return new SaveMemento("Player", _level);
        //return new Memento(moveSpeed, rotateSpeed, transform.position);
    }

    public void Restore(SaveMemento memento)
    {
        Debug.Log(memento.Level);
        _level = memento.Level;
        //moveSpeed = memento.MoveSpeed;
        //rotateSpeed = memento.TurnSpeed;
        //transform.position = memento.LastCheckpoint;

        Debug.Log("Data restored to last save...");
    }
}