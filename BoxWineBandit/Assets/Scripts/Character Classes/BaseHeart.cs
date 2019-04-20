using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHeart : BaseClass
{
    public BaseHeart()
    {

        CharacterClassName = "Heart of the Cards Mitch";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 280;
        Health = 280;
        Defense = 20;
        Power = 82;
        CritChance = 20;
        HitChance = 120;
        AbilityOne = new HeartAbilityOne();
        AbilityTwo = new HeartAbilityOne();
        Defeated = false;


    }
}
