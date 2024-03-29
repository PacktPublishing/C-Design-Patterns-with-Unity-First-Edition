using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        double points = Random.Range(1.0f, 3.0f);
        Client.Instance.Score += points;
        Client.Instance.Items++;

        Destroy(this.gameObject);
    }
}