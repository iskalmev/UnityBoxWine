using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBigMitch : BaseClass
{
    public BaseBigMitch()
    {

        CharacterClassName = "Big Mitch";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 550;
        Health = 550;
        Defense = 5;
        Power = 78;
        CritChance = 0;
        HitChance = 92;
        AbilityOne = new BaseBigMitchAbilityOne();
        AbilityTwo = new BaseBigMitchAbilityOne();
        Defeated = false;


    }
}
