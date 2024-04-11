using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    ILogContract _logging;
    ISaveContract _saving;

    void Start()
    {
        _logging = GenericLocator.GetService<ILogContract>();
        _saving = GenericLocator.GetService<ISaveContract>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

            _logging.Log("Item collected!");
            _saving.Save($"1 point");
        }
    }
}