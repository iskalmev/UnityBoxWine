
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNathan : BaseClass
{

    public BaseNathan()
    {

        CharacterClassName = "Nathan";
        CharacterClassDescription = "This is Nathan";
        MaxHealth = 120;
        Health = 120;
        Defense = 10;
        Power = 42;
        CritChance = 15;
        HitChance = 98;
        AbilityOne = new NathanAbilityOne();
        AbilityTwo = new NathanAbilityTwo();
        Defeated = false;

    }
}
