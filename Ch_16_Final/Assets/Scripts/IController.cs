using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IController
{
    int mSpeed { get; set; }

    void Move();
    void Jump();
}