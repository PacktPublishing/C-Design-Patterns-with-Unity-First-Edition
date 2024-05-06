using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyMail : Decorator
{
    GameObject _target;

    public HolyMail(ICharacter character, SOData data, GameObject target) : base(character, data)
    {
        _target = target;
    }

    public override void Battle()
    {
        AddEffect();
        base.Battle();
    }

    void AddEffect()
    {
        Renderer rend = _target.GetComponent<Renderer>();
        rend.material.SetColor("_Color", Color.red);
    }
}