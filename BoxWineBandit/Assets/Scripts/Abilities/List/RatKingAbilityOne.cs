using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatKingAbilityOne : BaseAbility
{


    public RatKingAbilityOne()
    {
        AbilityName = "Rat Throw";
        AbilityDesc = "Damage One Enemy\nReduces their Defense";
        AbilityType = 6;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("rat throw");
    }

}