using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Shared;    
    public Projectile pooledObject;    
    public int poolSize;

    private Queue<Projectile> _available = new Queue<Projectile>();    

    void Awake()    
    {
        Shared = this;
        FillPool();
    }

    void CreatePooledObject()    
    {
        Projectile bullet = Instantiate(pooledObject);    
        _available.Enqueue(bullet);    
        bullet.gameObject.transform.SetParent(this.transform);    
        bullet.gameObject.SetActive(false);    
    }

    void FillPool()    
    {
        for (int i = 0; i < poolSize; i++)    
        {
            CreatePooledObject();    
        }
    }

    public Projectile GetObject()    
    {
        if(_available.Count == 0)
        {
            return null;
        }

        lock(_available)
        {
            Projectile bullet = _available.Dequeue();
            bullet.gameObject.SetActive(true);

            return bullet;
        }
    }

    public void ReturnObject(Projectile bullet)    
    {
        lock(_available)
        {
            _available.Enqueue(bullet);
            bullet.gameObject.SetActive(false);
        }
    }
}