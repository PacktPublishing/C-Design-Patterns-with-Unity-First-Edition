using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int score = 0;
    public int startingLevel = 1;

    public void StartGame()
    {
        Debug.Log("New game has started...");
        SceneManager.LoadScene(startingLevel);
    }
}