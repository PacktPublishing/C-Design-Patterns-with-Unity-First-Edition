using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Element { None, Water, Fire, Grass, Ground, Ice }

[CreateAssetMenu(fileName = "SOType", menuName = "SO Type")]
public class SOType : ScriptableObject
{
    public SOType Parent;

    public int HP;
    public Color Color;
    public Element Element;
    public List<Element> Weaknesses;

    [ContextMenu("Inherit")]
    private void Configure()
    {
        if (HP == 0)
            HP = Parent.HP;
        if (Element == Element.None)
            Element = Parent.Element;

        Color = Utilities.MixColors(Color, Parent.Color);

        foreach (var parentWeakness in Parent.Weaknesses)
        {
            if (!Weaknesses.Contains(parentWeakness))
                Weaknesses.Add(parentWeakness);
        }
    }

    [ContextMenu("Inherit", true)]
    bool Validate()
    {
        return Parent != null;
    }
}