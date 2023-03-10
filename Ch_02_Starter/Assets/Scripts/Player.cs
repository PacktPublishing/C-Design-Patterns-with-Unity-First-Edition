using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    void Update()
    {
        float horInput = Input.GetAxis("Vertical") * moveSpeed;
        float verInput = Input.GetAxis("Horizontal") * rotateSpeed;

        this.transform.Translate(Vector3.forward * horInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * verInput * Time.deltaTime);
    }
}