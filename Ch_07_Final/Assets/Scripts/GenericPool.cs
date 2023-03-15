using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class GenericPool : MonoBehaviour
{
    public static GenericPool shared;

    public Projectile pooledObject;
    public int defaultCapacity = 5;    
    public int maxCapacity = 10;    
    public bool collectionChecks = true;

    private object _poolLock = new object();
    private IObjectPool<Projectile> _pool;
    public IObjectPool<Projectile> pool
    {
        get
        {
            if (_pool == null)
            {
                lock(_poolLock)
                {
                    _pool = new ObjectPool<Projectile>
                              (
                                CreatePooledObject,
                                TakeFromPool,
                                ReturnToPool,
                                DestroyPooledObject,
                                collectionChecks,
                                defaultCapacity,
                                maxCapacity
                            );
                }
            }

            return _pool;
        }
    }

    void Awake()
    {
        shared = this;
    }

    private Projectile CreatePooledObject()
    {
        Projectile bullet = Instantiate(pooledObject);
        bullet.gameObject.SetActive(false);
        bullet.transform.SetParent(this.transform);

        return bullet;
    }

    private void TakeFromPool(Projectile bullet)    
    {
        bullet.gameObject.SetActive(true);    
    }

    private void ReturnToPool(Projectile bullet)    
    {
        bullet.gameObject.SetActive(false);    
    }

    private void DestroyPooledObject(Projectile bullet)    
    {
        Destroy(bullet.gameObject);    
    }
}