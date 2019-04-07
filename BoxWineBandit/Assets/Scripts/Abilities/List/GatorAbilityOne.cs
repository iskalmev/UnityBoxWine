using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatorAbilityOne : BaseAbility
{
    

    public GatorAbilityOne()
    {
        AbilityName = "Gator Bite";
        AbilityDesc = "Bites Target";
        AbilityType = 1;
    }

    public void UseAbility(GameObject t, GameObject s)
    {
        GatorBite gatbit = new GatorBite();
        gatbit.getInfo(t, s);
    }
    
}
