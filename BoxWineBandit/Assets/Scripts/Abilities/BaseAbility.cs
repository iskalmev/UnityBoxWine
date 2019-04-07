using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAbility
{

    private string abilityName;
    private string abilityDesc;
    private int abilityType;

    public int AbilityType
    {
        get { return abilityType; }
        set { abilityType = value; }
    }

    public string AbilityName
    {
        get { return abilityName; }
        set { abilityName = value; }
    }

    public string AbilityDesc
    {
        get { return abilityDesc; }
        set { abilityDesc = value; }
    }

    public void UseAbility(GameObject t, GameObject s)
    {

    }


}
