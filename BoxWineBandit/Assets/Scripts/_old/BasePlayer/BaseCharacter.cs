using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter
{

    private int playerLevel;
    private BaseClass playerClass;
    private int health;
    private int hitChance;
    private int power;
    private int defense;
    private int critChance;

    //public int PlayerLevel { get; set; }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public BaseClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
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
