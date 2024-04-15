using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Element { None, Water, Fire, Grass, Ground, Ice }

[CreateAssetMenu(fileName = "SOType", menuName = "SO Type")]
public class SOType : ScriptableObject
{
    public SOType BaseType;

    public int HP;
    public Color Color;
    public Element Element;
    public List<Element> Weaknesses;

    [ContextMenu("Inherit")]
    private void Configure()
    {
        if (HP == 0)
            HP = BaseType.HP;
        if (Element == Element.None)
            Element = BaseType.Element;

        Color = Utilities.MixColors(Color, BaseType.Color);

        foreach (var baseWeakness in BaseType.Weaknesses)
        {
            if (!Weaknesses.Contains(baseWeakness))
                Weaknesses.Add(baseWeakness);
        }
    }

    [ContextMenu("Inherit", true)]
    bool Validate()
    {
        return BaseType != null;
    }
}