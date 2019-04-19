using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MadokaAbilityOne : BaseAbility
{


    public MadokaAbilityOne()
    {
        AbilityName = "magicbolt";
        AbilityDesc = "Damage One Target\nSelf Heal";
        AbilityType = 1;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("magicbolt");
    }
}
