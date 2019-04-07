using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NathanAbilityOne : BaseAbility
{


    public NathanAbilityOne()
    {
        AbilityName = "Steal Cat";
        AbilityDesc = "Steal Target's Cat";
        AbilityType = 1;
    }

    public void UseAbility(GameObject t, GameObject s)
    {
        StealCat catst = new StealCat();
        catst.getInfo(t, s);
    }
}