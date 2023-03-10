using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICopy
{
    public ICopy Copy();
}

public abstract class BaseEnemy : MonoBehaviour, ICopy
{
    [SerializeField] protected int Damage;
    [SerializeField] protected string Message;
    [SerializeField] protected string Name;

    public void OnEnable()
    {
        Debug.LogFormat($"{Message} - an {Name} entered the arena.");
    }

    public virtual void Attack()
    {
        Debug.LogFormat($"{Name} attacks for {Damage} HP!");
    }

    public ICopy Copy()
    {
        BaseEnemy clone = Instantiate(this);
        GameObject spawner = GameObject.Find("Enemy Spawner");
        var enemyRange = new Vector3(Random.Range(-7, 7), 0, Random.Range(-7, 7));

        clone.transform.SetParent(spawner.transform);
        clone.transform.localPosition = enemyRange;

        return clone;
    }
}