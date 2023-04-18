using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}