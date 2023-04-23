using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Rank;
    public float MoveSpeed = 10f;
    public float TurnSpeed = 75f;

    private Vector3 _moveVector;
    private Vector3 _rotationVector;

    public void ConfigureInput(Vector3 forward, Vector3 turning)
    {
        _moveVector = forward;
        _rotationVector = turning;
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        this.transform.Translate(_moveVector * Time.deltaTime);
        this.transform.Rotate(_rotationVector * Time.deltaTime);
    }
}