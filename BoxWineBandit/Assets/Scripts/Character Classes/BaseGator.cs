using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGator : BaseClass
{
    public BaseGator()
    {

        CharacterClassName = "Gator";
        CharacterClassDescription = "This is the Gator class";
        MaxHealth = 128;
        Health = 128;
        Defense = 22;
        Power = 42;
        CritChance = 0;
        HitChance = 95;
        AbilityOne = new GatorAbilityOne();
        AbilityTwo = new GatorAbilityOne();
        Defeated = false;
        

    }
}
