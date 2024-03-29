using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private MovementController _controller;

    void Start()
    {
        _controller = this.GetComponent<MovementController>();
    }

    void FixedUpdate()
    {
        _controller.Move();
        _controller.Jump();
    }
}