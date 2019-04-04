using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGator : BaseClass
{
    public BaseGator()
    {

        CharacterClassName = "Gator";
        CharacterClassDescription = "This is the Gator class";
        Health = 12;
        Defense = 14;
        Power = 10;
        CritChance = 15;
        HitChance = 10;
        //AbilityOne = new GatorBite();

    }
}
