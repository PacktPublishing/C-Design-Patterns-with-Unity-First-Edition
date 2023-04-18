using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public static Manager Instance { get; private set; }

    public UnitStats Player;
    public UnitStats Enemy;

    public TMP_Text PlayerStats;
    public TMP_Text EnemyStats;
    public GameObject PausePanel;
    public Light daylight;

    public bool isPaused;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    void Update()
    {
        PlayerStats.text = $"Health: {Player.Health}";
        EnemyStats.text = $"Health: {Enemy.Health}";
    }

    public void Pause()
    {
        isPaused = !isPaused;
        PausePanel.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void DayToNight()
    {
        StartCoroutine(LerpFunction(0.25f, 5));
    }

    public void NightToDay()
    {
        StartCoroutine(LerpFunction(1.0f, 5));
    }

    IEnumerator LerpFunction(float endValue, float duration)
    {
        float time = 0;
        float startValue = daylight.intensity;

        while (time < duration)
        {
            daylight.intensity = Mathf.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        daylight.intensity = endValue;
    }
}