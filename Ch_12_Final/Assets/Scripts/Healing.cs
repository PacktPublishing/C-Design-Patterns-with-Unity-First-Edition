using UnityEngine;

public class Healing : MonoBehaviour, IEnemyStrategy
{
    public void Think()
    {
        Debug.Log("Healing protocol: use potion if available.");
    }

    public void React(EnemyContext context)
    {
        //var renderer = GetComponent<Renderer>();
        //renderer.material.SetColor("_Color", Color.green);
    }
}