using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public string Name;

    public SOType PokemonType;
    public int Health;
    public Element Element;
    public List<Element> Weaknesses;

    void Start()
    {
        Health = PokemonType.HP;
        Element = PokemonType.Element;
        Weaknesses = PokemonType.Weaknesses;

        var renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", PokemonType.Color);
    }
}