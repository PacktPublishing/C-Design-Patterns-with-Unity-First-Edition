using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Item collected!");
        Destroy(this.gameObject);
    }
} 