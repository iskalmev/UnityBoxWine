using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBigMitchAbilityOne : BaseAbility
{


    public BaseBigMitchAbilityOne()
    {
        AbilityName = "Stomp";
        AbilityDesc = "Stomp Target";
        AbilityType = 1;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("Stomp");
    }
}
