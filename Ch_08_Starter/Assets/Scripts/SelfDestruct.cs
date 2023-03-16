using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float timer = 2f;

    void Start()
    {
        Destroy(this.gameObject, timer);
    }
}