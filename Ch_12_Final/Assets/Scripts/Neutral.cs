using UnityEngine;

public class Neutral : MonoBehaviour, IEnemyStrategy
{
    public void Think()
    {
        Debug.Log("Neutral protocol: delay action until more data is processed...");
    }

    public void React(EnemyContext context)
    {
        Debug.Log("Neutral protocol: delay action until more data is processed...");
    }
}