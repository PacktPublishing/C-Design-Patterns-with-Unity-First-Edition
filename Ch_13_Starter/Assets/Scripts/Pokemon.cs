using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Element { None, Water, Fire, Grass, Ground, Ice }

public class Pokemon : MonoBehaviour
{
    public string Name;
    public int Health;
    public Element Element;
    public List<Element> Weaknesses;

    void Start()
    {

    }
}