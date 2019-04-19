using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxWineBanditAbilityOne : BaseAbility
{
    

    public BoxWineBanditAbilityOne()
    {
        AbilityName = "Cinder Strike";
        AbilityDesc = "Damage One Enemy";
        AbilityType = 1;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        Debug.Log("mitcj attack");
        
    }
}
