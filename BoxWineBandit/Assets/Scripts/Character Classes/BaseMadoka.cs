using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMadoka : BaseClass
{
    public BaseMadoka()
    {

        CharacterClassName = "Madoka Mitchika";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 220;
        Health = 220;
        Defense = 11;
        Power = 103;
        CritChance = 1;
        HitChance = 110;
        AbilityOne = new MadokaAbilityOne();
        AbilityTwo = new MadokaAbilityOne();
        Defeated = false;


    }
}
