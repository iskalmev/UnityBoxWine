using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NathanAbilityOne : BaseAbility
{


    public NathanAbilityOne()
    {
        AbilityName = "Steal Cat";
        AbilityDesc = "Damage One Target\nSelf Heal";
        AbilityType = 5;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("steal cat");
    }
}