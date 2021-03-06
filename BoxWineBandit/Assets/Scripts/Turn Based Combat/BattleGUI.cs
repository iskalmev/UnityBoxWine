﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleGUI : MonoBehaviour
{

    public static UnityEngine.UI.Image EnemyOneImage;
    public static UnityEngine.UI.Image EnemyTwoImage;
    public static UnityEngine.UI.Image EnemyThreeImage;
    public static UnityEngine.UI.Image MCImage;
    public static UnityEngine.UI.Image RatKingImage;
    public static UnityEngine.UI.Image NathanImage;


    public static UnityEngine.GameObject EnemyOneOb;
    public static UnityEngine.GameObject EnemyTwoOb;
    public static UnityEngine.GameObject EnemyThreeOb;
    public static UnityEngine.GameObject MCOb;
    public static UnityEngine.GameObject RatKingOb;
    public static UnityEngine.GameObject NathanOb;

    public static UnityEngine.GameObject gatorBite;

    public static UnityEngine.UI.Text textBoi;



    public static GameObject mitchAttack, mitchWine, ratThrown, ratWall, nathanSteal, nathanRanch, gatorAttack;



    // Start is called before the first frame update
    void Start()
    {

        textBoi = transform.Find("Text").GetComponent<UnityEngine.UI.Text>();

        


        EnemyOneImage = transform.Find("EnemyOneImage").GetComponent<UnityEngine.UI.Image>();
        EnemyTwoImage = transform.Find("EnemyTwoImage").GetComponent<UnityEngine.UI.Image>();
        EnemyThreeImage = transform.Find("EnemyThreeImage").GetComponent<UnityEngine.UI.Image>();
        MCImage = transform.Find("MCimage").GetComponent<UnityEngine.UI.Image>();
        RatKingImage = transform.Find("RatKingImage").GetComponent<UnityEngine.UI.Image>();
        NathanImage = transform.Find("NathanImage").GetComponent<UnityEngine.UI.Image>();


        EnemyOneOb = transform.Find("EnemyOne").GetComponent<UnityEngine.GameObject>();
        EnemyTwoOb = transform.Find("EnemyTwo").GetComponent<UnityEngine.GameObject>();
        EnemyThreeOb = transform.Find("EnemyThree").GetComponent<UnityEngine.GameObject>();
        MCOb = transform.Find("Mitch").GetComponent<UnityEngine.GameObject>();
        RatKingOb = transform.Find("RatKingImage").GetComponent<UnityEngine.GameObject>();
        NathanOb = transform.Find("NathanImage").GetComponent<UnityEngine.GameObject>();

        gatorBite = transform.Find("GatorBite0000").GetComponent<UnityEngine.GameObject>();


        gatorAttack = this.gameObject.GetComponent<AbilityHolder>().gatorAttack;


    }

    // Update is called once per frame
    void Update()
    {






        BattleGUI.EnemyOneImage.fillAmount = (float)(TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne.Health) / (float)(TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne.MaxHealth);
        BattleGUI.EnemyTwoImage.fillAmount = (float)(TurnBasedCombatStateMachine.battleStateStartScript.EnemyTwo.Health) / (float)(TurnBasedCombatStateMachine.battleStateStartScript.EnemyTwo.MaxHealth);
        BattleGUI.EnemyThreeImage.fillAmount = (float)(TurnBasedCombatStateMachine.battleStateStartScript.EnemyThree.Health) / (float)(TurnBasedCombatStateMachine.battleStateStartScript.EnemyThree.MaxHealth);
        BattleGUI.MCImage.fillAmount = (float)(TurnBasedCombatStateMachine.battleStateStartScript.MC.Health) / (float)(TurnBasedCombatStateMachine.battleStateStartScript.MC.MaxHealth);
        BattleGUI.RatKingImage.fillAmount = (float)(TurnBasedCombatStateMachine.battleStateStartScript.ratKing.Health) / (float)(TurnBasedCombatStateMachine.battleStateStartScript.ratKing.MaxHealth);
        BattleGUI.NathanImage.fillAmount = (float)(TurnBasedCombatStateMachine.battleStateStartScript.nathan.Health) / (float)(TurnBasedCombatStateMachine.battleStateStartScript.nathan.MaxHealth);

    }

    private void OnGUI()
    {
        
        if (TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE)
        {
            DisplayPlayerChoice();
        } else if (TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.RATCHOICE) {
            DisplayRatChoice();
        }else if (TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.NATHANCHOICE)
        {
            DisplayNathanChoice();
        }
        else if (TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.CHOOSETARGET)
        {
            if (TurnBasedCombatStateMachine.usedAbilty.AbilityType == 1 || TurnBasedCombatStateMachine.usedAbilty.AbilityType == 4 
                || TurnBasedCombatStateMachine.usedAbilty.AbilityType == 5 || TurnBasedCombatStateMachine.usedAbilty.AbilityType == 6 || TurnBasedCombatStateMachine.usedAbilty.AbilityType == 10)
            {
                DisplayTargetChoice();
            }
            else
            {
                DisplayAllyChoice();
            }

        }
        



    }

    private void DisplayPlayerChoice()
    {
        
        if (GUI.Button(new Rect(Screen.width/2-185, Screen.height - 95, 170, 65),
            (TurnBasedCombatStateMachine.battleStateStartScript.MC.AbilityOne.AbilityName + "\n" + TurnBasedCombatStateMachine.battleStateStartScript.MC.AbilityOne.AbilityDesc)))
        {
            TurnBasedCombatStateMachine.usedAbilty = TurnBasedCombatStateMachine.battleStateStartScript.MC.AbilityOne;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CHOOSETARGET;
        }
        if (GUI.Button(new Rect(Screen.width / 2 + 35, Screen.height - 95, 170, 65),
            (TurnBasedCombatStateMachine.battleStateStartScript.MC.AbilityTwo.AbilityName + "\n" + TurnBasedCombatStateMachine.battleStateStartScript.MC.AbilityTwo.AbilityDesc)))
        {
            TurnBasedCombatStateMachine.usedAbilty = TurnBasedCombatStateMachine.battleStateStartScript.MC.AbilityTwo;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CHOOSETARGET;
        }
    }

    private void DisplayRatChoice()
    {

        if (GUI.Button(new Rect(Screen.width / 2 - 185, Screen.height - 95, 170, 65),
            (TurnBasedCombatStateMachine.battleStateStartScript.ratKing.AbilityOne.AbilityName + "\n" + TurnBasedCombatStateMachine.battleStateStartScript.ratKing.AbilityOne.AbilityDesc)))
        {
            TurnBasedCombatStateMachine.usedAbilty = TurnBasedCombatStateMachine.battleStateStartScript.ratKing.AbilityOne;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CHOOSETARGET;
        }
        if (GUI.Button(new Rect(Screen.width / 2 + 35, Screen.height - 95, 170, 65),
            (TurnBasedCombatStateMachine.battleStateStartScript.ratKing.AbilityTwo.AbilityName + "\n" + TurnBasedCombatStateMachine.battleStateStartScript.ratKing.AbilityTwo.AbilityDesc)))
        {
            TurnBasedCombatStateMachine.usedAbilty = TurnBasedCombatStateMachine.battleStateStartScript.ratKing.AbilityTwo;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CHOOSETARGET;
        }
    }
    


    private void DisplayNathanChoice()
    {

        if (GUI.Button(new Rect(Screen.width / 2 - 185, Screen.height - 95, 170, 65),
            (TurnBasedCombatStateMachine.battleStateStartScript.nathan.AbilityOne.AbilityName + "\n" + TurnBasedCombatStateMachine.battleStateStartScript.nathan.AbilityOne.AbilityDesc)))
        {
            TurnBasedCombatStateMachine.usedAbilty = TurnBasedCombatStateMachine.battleStateStartScript.nathan.AbilityOne;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CHOOSETARGET;
        }
        if (GUI.Button(new Rect(Screen.width / 2 + 35, Screen.height - 95, 170, 65),
            (TurnBasedCombatStateMachine.battleStateStartScript.nathan.AbilityTwo.AbilityName + "\n" + TurnBasedCombatStateMachine.battleStateStartScript.nathan.AbilityTwo.AbilityDesc)))
        {
            TurnBasedCombatStateMachine.usedAbilty = TurnBasedCombatStateMachine.battleStateStartScript.nathan.AbilityTwo;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CHOOSETARGET;
        }
    }

    private void DisplayTargetChoice()
    {

        if (!TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne.Defeated)
        {
            if (GUI.Button(new Rect(Screen.width / 3 - 75, Screen.height - 65, 165, 30), TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne.CharacterClassName))
            {
                TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne;
                TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATEDAMAGE;
            }
        }
        if (!TurnBasedCombatStateMachine.battleStateStartScript.EnemyTwo.Defeated)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height - 65, 165, 30), TurnBasedCombatStateMachine.battleStateStartScript.EnemyTwo.CharacterClassName))
            {
                TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.EnemyTwo;
                TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATEDAMAGE;
            }
        }
        if (!TurnBasedCombatStateMachine.battleStateStartScript.EnemyThree.Defeated)
        {
            if (GUI.Button(new Rect(Screen.width / 3 * 2 - 75, Screen.height - 65, 165, 30), TurnBasedCombatStateMachine.battleStateStartScript.EnemyThree.CharacterClassName))
            {
                TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.EnemyThree;
                TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATEDAMAGE;
            }
        }
    }

    private void DisplayAllyChoice()
    {

        if (!TurnBasedCombatStateMachine.battleStateStartScript.MC.Defeated)
        {
            if (GUI.Button(new Rect(Screen.width / 3 - 75, Screen.height - 50, 150, 30), TurnBasedCombatStateMachine.battleStateStartScript.MC.CharacterClassName))
            {
                TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.MC;
                TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATEDAMAGE;
            }
        }
        if (!TurnBasedCombatStateMachine.battleStateStartScript.ratKing.Defeated)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height - 50, 150, 30), TurnBasedCombatStateMachine.battleStateStartScript.ratKing.CharacterClassName))
            {
                TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.ratKing;
                TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATEDAMAGE;
            }
        }
        if (!TurnBasedCombatStateMachine.battleStateStartScript.nathan.Defeated)
        {
            if (GUI.Button(new Rect(Screen.width / 3 * 2 - 75, Screen.height - 50, 150, 30), TurnBasedCombatStateMachine.battleStateStartScript.nathan.CharacterClassName))
            {
                TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.nathan;
                TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATEDAMAGE;
            }
        }
    }



}
