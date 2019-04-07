using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatKingAbilityOne : BaseAbility
{


    public RatKingAbilityOne()
    {
        AbilityName = "Rat Throw";
        AbilityDesc = "ThrowsRat";
        AbilityType = 1;
    }

    public void UseAbility(GameObject t, GameObject s)
    {
        RatThrow ratthrow = new RatThrow();
        ratthrow.getInfo(t, s);
    }

}