using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartAbilityOne : BaseAbility
{


    public HeartAbilityOne()
    {
        AbilityName = "throwcard";
        AbilityDesc = "Damage One Target\nSelf Heal";
        AbilityType = 1;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("throw card");
    }
}
