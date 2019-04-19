using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMadoka : BaseClass
{
    public BaseMadoka()
    {

        CharacterClassName = "Madoka Mitchika";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 35;
        Health = 35;
        Defense = 0;
        Power = 7;
        CritChance = 0;
        HitChance = 95;
        AbilityOne = new MadokaAbilityOne();
        AbilityTwo = new MadokaAbilityOne();
        Defeated = false;


    }
}
