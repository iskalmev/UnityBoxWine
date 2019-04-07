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

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("gatorBite");
    }
    
}
