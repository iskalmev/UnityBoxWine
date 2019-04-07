using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGator : BaseClass
{
    public BaseGator()
    {

        CharacterClassName = "Gator";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 10;
        Health = 10;
        Defense = 2;
        Power = 4;
        CritChance = 0;
        HitChance = 95;
        AbilityOne = new GatorAbilityOne();
        AbilityTwo = new GatorAbilityOne();
        Defeated = false;
        

    }
}
