using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDifficultyStrategy
{
    float Configure(int level);
}

public class Normal : IDifficultyStrategy
{
    public float Configure(int level)
    {
        //Debug.Log("I can respect the middle of the road...");
        return (float)(level + 1);
    }
}

public class Nightmare : IDifficultyStrategy
{
    public float Configure(int level)
    {
        //Debug.Log("This isn't going to go your way...");
        return (float)(level * 2.5);
    }
}

public class DifficultyContext
{
    public int Level = 1;
    public float Damage = 1;
    public string Name;

    private IDifficultyStrategy _strategy;

    public DifficultyContext(string name, IDifficultyStrategy strategy = null)
    {
        Name = name;
        _strategy = strategy;
    }

    public void SetStrategy(IDifficultyStrategy newStrategy)
    {
        _strategy = newStrategy;
    }

    public void ShowDifficultySettings()
    {
        if (_strategy == null)
        {
            Debug.LogFormat($"Difficulty set to defaults...");
        }
        else
        {
            Damage = _strategy.Configure(Level);
            Debug.LogFormat($"Difficulty updated -> {_strategy.GetType().Name}: {Name} does x{Damage} more damage!");
        }
    }
}