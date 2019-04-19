using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NathanAbilityTwo : BaseAbility
{


    public NathanAbilityTwo()
    {
        AbilityName = "Spill Ranch";
        AbilityDesc = "Reduce Enemy Accuracy";
        AbilityType = 4;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("spill ranch");
    }
}