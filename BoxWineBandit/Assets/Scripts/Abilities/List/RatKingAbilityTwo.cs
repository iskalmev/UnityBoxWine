﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatKingAbilityTwo : BaseAbility
{


    public RatKingAbilityTwo()
    {
        AbilityName = "Rat Wall";
        AbilityDesc = "Buff Ally Crit Chance";
        AbilityType = 3;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("rat wall");
    }
}
