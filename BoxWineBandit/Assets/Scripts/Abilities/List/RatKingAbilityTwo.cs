using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatKingAbilityTwo : BaseAbility
{


    public RatKingAbilityTwo()
    {
        AbilityName = "Rat Wall";
        AbilityDesc = "Summon a Wall of Rats to Block a attack";
        AbilityType = 3;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("rat wall");
    }
}
