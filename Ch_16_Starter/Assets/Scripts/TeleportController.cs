using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TeleportController : MonoBehaviour
{
    public int followDelay = 35;

    [NonSerialized]
    public Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    public void TeleportPlayer()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 newPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            rb.MovePosition(newPos * followDelay * Time.deltaTime);
        }
    }
}