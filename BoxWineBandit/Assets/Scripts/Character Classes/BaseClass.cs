using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass
{

    private string characterClassName;
    private string characterClassDescription;
    //Stats
    private int health;
    private int hitChance;
    private int power;
    private int defense;
    private int critChance;
    private BaseAbility abilityOne;

    public BaseAbility AbilityOne
    {
        get { return abilityOne; }
        set { abilityOne = value; }
    }

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int HitChance
    {
        get { return hitChance; }
        set { hitChance = value; }
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }

    public int CritChance
    {
        get { return critChance; }
        set { critChance = value; }
    }
}
