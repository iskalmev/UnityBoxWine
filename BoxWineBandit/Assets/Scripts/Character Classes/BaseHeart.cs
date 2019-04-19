using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHeart : BaseClass
{
    public BaseHeart()
    {

        CharacterClassName = "Heart of the Cards Mitch";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 35;
        Health = 35;
        Defense = 0;
        Power = 7;
        CritChance = 0;
        HitChance = 95;
        AbilityOne = new HeartAbilityOne();
        AbilityTwo = new HeartAbilityOne();
        Defeated = false;


    }
}
