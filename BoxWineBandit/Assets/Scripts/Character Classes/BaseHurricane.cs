using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHurricane : BaseClass
{
    public BaseHurricane()
    {

        CharacterClassName = "Hurricane";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 250;
        Health = 250;
        Defense = 30;
        Power = 60;
        CritChance = 0;
        HitChance = 82;
        AbilityOne = new HurricaneAbilityOne();
        AbilityTwo = new HurricaneAbilityOne();
        Defeated = false;


    }
}
