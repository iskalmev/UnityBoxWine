using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRatKing : BaseClass
{

    public BaseRatKing()
    {

        CharacterClassName = "Rat King";
        CharacterClassDescription = "King of the Rats";
        MaxHealth = 105;
        Health = 105;
        Defense = 28;
        Power = 40;
        CritChance = 5;
        HitChance = 96;
        AbilityOne = new RatKingAbilityOne();
        AbilityTwo = new RatKingAbilityTwo();
        Defeated = false;

    }
}
