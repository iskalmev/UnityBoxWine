using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRatKing : BaseClass
{

    public BaseRatKing()
    {

        CharacterClassName = "Rat King";
        CharacterClassDescription = "King of the Rats";
        MaxHealth = 12;
        Health = 12;
        Defense = 1;
        Power = 5;
        CritChance = 5;
        HitChance = 95;
        AbilityOne = new RatKingAbilityOne();
        AbilityTwo = new RatKingAbilityTwo();
        Defeated = false;

    }
}
