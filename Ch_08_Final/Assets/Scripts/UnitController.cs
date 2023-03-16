using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    public int distance;
    public GameObject projectile;
    public GameObject shield;
    public float projectileSpeed = 100f;

    private Transform _transform;

    void Start()
    {
        _transform = this.GetComponent<Transform>();
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(projectile, _transform.position + Vector3.zero, _transform.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.velocity = _transform.forward * projectileSpeed;
        Debug.Log("Command received -> projectile shot!");
    }

    public void Melee()
    {
        StartCoroutine(Utilities.Rotate(_transform));
        Debug.Log("Command received -> melee attack!");
    }

    public void Block()
    {
        GameObject newShield = Instantiate(shield, _transform.position + Vector3.forward * 1, _transform.rotation);
        newShield.transform.SetParent(_transform);
        Debug.Log("Command received -> shield up!");
    }

    public void Move(Vector3 targetPos)
    {
        _transform.position = targetPos;
    }
}