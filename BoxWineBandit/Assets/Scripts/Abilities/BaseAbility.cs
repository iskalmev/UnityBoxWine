using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAbility
{

    private string abilityName;
    private string abilityDesc;


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

    public void activateAbility(string abilityName, Vector3 source, Vector3 target)
    {


    }


}
