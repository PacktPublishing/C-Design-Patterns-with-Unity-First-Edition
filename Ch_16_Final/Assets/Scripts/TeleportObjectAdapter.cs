using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObjectAdapter : MonoBehaviour, IController
{
    public int mSpeed
    {
        get { return _adaptee.moveSpeed; }
        set { _adaptee.moveSpeed = value; }
    }

    public float hoverHeight = 3;

    private bool _isLevitating;
    private TeleportController _adaptee;

    void Start()
    {
        _adaptee = this.GetComponent<TeleportController>();
    }

    void Update()
    {
        _isLevitating = Input.GetKey(KeyCode.Space);
    }

    public void Move()
    {
        _adaptee.TeleportPlayer();
        Debug.Log("Using adapted movement behavior from TeleportController...");
    }

    public void Jump()
    {
        if (_isLevitating)
        {
            Vector3 hover = this.transform.position;
            hover.y = (Vector3.up * hoverHeight).y;
            _adaptee.rb.position = hover;
        }

        Debug.Log("Using new jump behavior from TeleportClassAdapter...");
    }
}