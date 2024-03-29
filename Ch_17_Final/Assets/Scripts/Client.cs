using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Client : MonoBehaviour
{
    public static Client Instance;
    public TMP_Text scoreUI;
    public AutosaveFacade facade;

    private int _itemsCollected = 0;
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            if (_itemsCollected % 3 == 0)
            {
                StartCoroutine(facade.Save(_score));
            }
        }
    }

    private double _score = 0.0;
    public double Score
    {
        get { return _score; }
        set
        {
            _score = value;
            scoreUI.text = $"Score: {_score.ToString("0.0")}";
        }
    }

    void Awake()
    {
        facade = this.gameObject.AddComponent<AutosaveFacade>();

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
        }
    }
}