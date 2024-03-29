using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private IController _controller;

    void Start()
    {
        _controller = this.GetComponent<TeleportClassAdapter>();
        Debug.Log(_controller.mSpeed);
    }

    void FixedUpdate()
    {
        _controller.Move();
        _controller.Jump();
    }
}