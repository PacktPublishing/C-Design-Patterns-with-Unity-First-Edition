using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject pauseUI;

    public void PauseScene()
    {
        Debug.Log("Pausing scene...");
        Time.timeScale = 0;
        pauseUI.gameObject.SetActive(true);
    }

    public void UnpauseScene()
    {
        Debug.Log("Unpausing scene...");
        Time.timeScale = 1;
        pauseUI.gameObject.SetActive(false);
    }
}