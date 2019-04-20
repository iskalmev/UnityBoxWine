using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMadoka : BaseClass
{
    public BaseMadoka()
    {

        CharacterClassName = "Madoka Mitchika";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 200;
        Health = 200;
        Defense = 11;
        Power = 73;
        CritChance = 0;
        HitChance = 110;
        AbilityOne = new MadokaAbilityOne();
        AbilityTwo = new MadokaAbilityOne();
        Defeated = false;


    }
}
