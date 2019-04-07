using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatKingAbilityTwo : BaseAbility
{


    public RatKingAbilityTwo()
    {
        AbilityName = "Rat Wall";
        AbilityDesc = "Summon a Wall of Rats to Block a attack";
        AbilityType = 3;
    }

    public void UseAbility(GameObject t, GameObject s)
    {
        RatWall ratwal = new RatWall();
        ratwal.getInfo(t, s);
    }
}
