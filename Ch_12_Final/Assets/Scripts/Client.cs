using UnityEngine;

public enum EnemyStrategy { Aggressive, Healing, Neutral }

public class Client : MonoBehaviour
{
    public EnemyStrategy EnemyStrategy;
    public EnemyContext EnemyContext;

    void Start()
    {
        var playerContext = new DifficultyContext("Player");
        playerContext.ShowDifficultySettings();

        playerContext.SetStrategy(new Nightmare());
        playerContext.ShowDifficultySettings();

        var enemyContext = new DifficultyContext("Enemy", new Normal());
        enemyContext.ShowDifficultySettings();
    }
}