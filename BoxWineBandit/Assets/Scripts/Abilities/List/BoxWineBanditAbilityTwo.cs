using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxWineBanditAbilityTwo : BaseAbility
{


    public BoxWineBanditAbilityTwo()
    {
        AbilityName = "Box Wine";
        AbilityDesc = "Heal One Ally";
        AbilityType = 2;
    }

    public override void UseAbility(GameObject t, GameObject s)
    {
        BoxWine boxy = new BoxWine();
        boxy.getInfo(t, s);
    }
}
