using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthAmulet : Decorator
{
    public StrengthAmulet(ICharacter character, SOData data) : base(character, data) { }

    public override int Strength()
    {
        return base.Strength();
    }

    public override void Battle()
    {
        base.Battle();
    }
}