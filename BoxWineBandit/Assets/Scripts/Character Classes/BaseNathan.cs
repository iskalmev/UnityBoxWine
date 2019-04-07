using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNathan : BaseClass
{

    public BaseNathan()
    {

        CharacterClassName = "Nathan";
        CharacterClassDescription = "This is Nathan";
        MaxHealth = 12;
        Health = 12;
        Defense = 1;
        Power = 5;
        CritChance = 5;
        HitChance = 95;
        AbilityOne = new NathanAbilityOne();
        AbilityTwo = new NathanAbilityTwo();
        Defeated = false;

    }
}
