using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{
    public ICharacter Base;

    public SOData BaseData;
    public SOData MainDecorator;
    public SOData SecondaryDecorator;

    void Start()
    { 
        Reset();
    }

    public void Decorate()
    {
        Base = new StrengthAmulet(new HolyMail(Base, MainDecorator, this.gameObject), SecondaryDecorator);
    }

    public void Battle()
    {
        Base.Battle();
    }

    public void Reset()
    {
        Base = new BaseCharacter(BaseData);
        Debug.Log("Card set to default values...");
    }
}