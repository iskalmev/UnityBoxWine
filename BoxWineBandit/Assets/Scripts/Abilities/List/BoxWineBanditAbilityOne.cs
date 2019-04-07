using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxWineBanditAbilityOne : BaseAbility
{
    

    public BoxWineBanditAbilityOne()
    {
        AbilityName = "Cinder Strike";
        AbilityDesc = "Flaming Slashes";
        AbilityType = 1;
    }

    public void UseAbility(GameObject t, GameObject s)
    {
        MitchAttack cinder = new MitchAttack();
        cinder.getInfo(t, s);
    }
}
