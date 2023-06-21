using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Button start;

    void Start()
    {
        start.onClick.AddListener(SOManager.Instance.StartGame);
    }
}