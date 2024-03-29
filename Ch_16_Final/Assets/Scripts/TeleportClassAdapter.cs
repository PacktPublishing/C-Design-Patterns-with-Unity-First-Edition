using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportClassAdapter : TeleportController, IController
{
    public int mSpeed
    {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }

    public float hoverHeight = 3;
    private bool _isLevitating;

    void Update()
    {
        _isLevitating = Input.GetKey(KeyCode.Space);
    }

    public void Move()
    {
        TeleportPlayer();
        Debug.Log("Using adapted movement behavior from TeleportController...");
    }

    public void Jump()
    {
        if (_isLevitating)
        {
            Vector3 hover = this.transform.position;
            hover.y = (Vector3.up * hoverHeight).y;
            rb.position = hover;
        }

        Debug.Log("Using new jump behavior from TeleportClassAdapter...");
    }
}