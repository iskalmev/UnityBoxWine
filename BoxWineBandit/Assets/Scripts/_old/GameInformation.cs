using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static BaseCharacter BoxWineBandit { get; set; }
    //public static int PlayerLevel { get; set; }
    //public static BaseClass PlayerClass { get; set; }
    //public static int Health { get; set; }
    //public static int HitChance { get; set; }
    //public static int Power { get; set; }
    //public static int Defense { get; set; }
    //public static int CritChance { get; set; }

   
}
