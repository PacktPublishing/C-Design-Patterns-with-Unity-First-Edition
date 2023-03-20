using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyManager : MonoBehaviour
{
    public int HealthMissed = 0;
    public int PlayerHits = 0;

    public void OnEnable()    
    {
        BasePrefab.OnHealthDestroyed += HealthDestroyed;
        BasePrefab.OnEnemyDestroyed += EnemyDestroyed;
    }

    void HealthDestroyed()    
    {
        HealthMissed++;    

        if (HealthMissed == 3)    
        {
            Debug.Log("Achievement unlocked: Living on the edge!");    
            BasePrefab.OnHealthDestroyed -= HealthDestroyed;    
        }
    }

    void EnemyDestroyed()    
    {
        Debug.Log("Achievement unlocked: Close encounters!");    
        BasePrefab.OnEnemyDestroyed -= EnemyDestroyed;    
    }

    public void PlayerDamaged(string message)
    {
        Debug.Log("Achievement unlocked: First blood!");
        Debug.Log(message);
    }
}