using UnityEngine;

public class Aggressive : MonoBehaviour, IEnemyStrategy
{
    public void Think()
    {
        Debug.Log("Aggressive protocol: seek-and-destroy!");
    }

    public void React(EnemyContext context)
    {
        //var player = GameObject.FindObjectOfType<Player>();
        //Rigidbody rb = GetComponent<Rigidbody>();

        //rb.MovePosition(player.transform.position);
    }
}