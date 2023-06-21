using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Restore game to last checkpoint...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}