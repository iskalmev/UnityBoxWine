using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBoxWineBandit : BaseClass
{

    public BaseBoxWineBandit()
    {

        CharacterClassName = "Box Wine Bandit";
        CharacterClassDescription = "This is Main Character Class";
        MaxHealth = 12;
        Health = 12;
        Defense = 1;
        Power = 5;
        CritChance = 5;
        HitChance = 95;
        AbilityOne = new BoxWineBanditAbilityOne();
        AbilityTwo = new BoxWineBanditAbilityTwo();
        Defeated = false;

    }
}