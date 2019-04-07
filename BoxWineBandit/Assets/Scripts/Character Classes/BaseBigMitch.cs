using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBigMitch : BaseClass
{
    public BaseBigMitch()
    {

        CharacterClassName = "Big Mitch";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 35;
        Health = 35;
        Defense = 0;
        Power = 7;
        CritChance = 0;
        HitChance = 95;
        AbilityOne = new BaseBigMitchAbilityOne();
        AbilityTwo = new BaseBigMitchAbilityOne();
        Defeated = false;


    }
}
