using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurricaneAbilityOne : BaseAbility
{


    public HurricaneAbilityOne()
    {
        AbilityName = "Airblast";
        AbilityDesc = "Blasts Target";
        AbilityType = 1;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("air blast");
    }
}
