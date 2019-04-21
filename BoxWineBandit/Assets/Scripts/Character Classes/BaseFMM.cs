using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFMM : BaseClass
{
    public BaseFMM()
    {

        CharacterClassName = "FMM";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 1;
        Health = 1;
        Defense = 0;
        Power = 0;
        CritChance = 0;
        HitChance = 0;
        AbilityOne = new FMMAbilityOne();
        AbilityTwo = new FMMAbilityOne();
        Defeated = false;


    }
}
