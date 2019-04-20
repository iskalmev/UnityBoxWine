using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBoxWineBandit : BaseClass
{

    public BaseBoxWineBandit()
    {

        CharacterClassName = "Box Wine Bandit";
        CharacterClassDescription = "This is Main Character Class";
        MaxHealth = 140;
        Health = 140;
        Defense = 7;
        Power = 65;
        CritChance = 8;
        HitChance = 95;
        AbilityOne = new BoxWineBanditAbilityOne();
        AbilityTwo = new BoxWineBanditAbilityTwo();
        Defeated = false;

    }
}