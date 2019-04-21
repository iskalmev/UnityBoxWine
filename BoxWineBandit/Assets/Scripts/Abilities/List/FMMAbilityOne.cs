using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMMAbilityOne : BaseAbility
{


    public FMMAbilityOne()
    {
        AbilityName = "Box Wine";
        AbilityDesc = "Heal One Ally\nWhile Reducing their Defense";
        AbilityType = 10;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        BoxWine boxy = new BoxWine();
        boxy.getInfo(t, s);
    }
}
