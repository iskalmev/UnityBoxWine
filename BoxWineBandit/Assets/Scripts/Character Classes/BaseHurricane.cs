using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHurricane : BaseClass
{
    public BaseHurricane()
    {

        CharacterClassName = "Hurricane";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 20;
        Health = 20;
        Defense = 0;
        Power = 6;
        CritChance = 0;
        HitChance = 85;
        AbilityOne = new HurricaneAbilityOne();
        AbilityTwo = new HurricaneAbilityOne();
        Defeated = false;


    }
}
