using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour
{

    public static BattleStateStart battleStateStartScript = new BattleStateStart();
    public static BaseAbility usedAbilty;
    public static BaseClass currentCharacter;
    public static BaseClass targetCharacter;
    private BattleCalculations battleCalcScript = new BattleCalculations();


    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        RATCHOICE,
        NATHANCHOICE,
        CHOOSETARGET,
        PLAYERANIMATE,
        ENEMYONECHOICE,
        ENEMYTWOCHOICE,
        ENEMYTHREECHOICE,
        ENEMYANIMATE,
        LOSE,
        WIN,
        CALCULATEDAMAGE
    }

    public static BattleStates currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = BattleStates.START;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentState);
        switch (currentState)
        {
            case (BattleStates.START):

                battleStateStartScript.PrepareBattle();
                currentState = BattleStates.PLAYERCHOICE;
                break;
            case (BattleStates.PLAYERCHOICE):
                currentCharacter = battleStateStartScript.MC;
                if (currentCharacter.Defeated)
                {
                    currentState = BattleStates.RATCHOICE;
                }
                break;
            case (BattleStates.NATHANCHOICE):
                currentCharacter = battleStateStartScript.nathan;
                if (currentCharacter.Defeated)
                {
                    currentState = BattleStates.ENEMYONECHOICE;
                }
                break;
            case (BattleStates.RATCHOICE):
                currentCharacter = battleStateStartScript.ratKing;
                if (currentCharacter.Defeated)
                {
                    currentState = BattleStates.NATHANCHOICE;
                }
                break;
            case (BattleStates.CHOOSETARGET):



                break;
            case (BattleStates.CALCULATEDAMAGE):

                battleCalcScript.CalculateUsedAbilityDamage(usedAbilty);
                if(WinLossCheck() == 1)
                {
                    currentState = BattleStates.LOSE;
                }
                else if (WinLossCheck() == 2)
                {
                    currentState = BattleStates.WIN;
                }
                else if (currentCharacter == battleStateStartScript.MC)
                {
                    currentState = BattleStates.RATCHOICE;
                }
                else if (currentCharacter == battleStateStartScript.ratKing)
                {
                    currentState = BattleStates.NATHANCHOICE;
                }
                else if (currentCharacter == battleStateStartScript.nathan)
                {
                    currentState = BattleStates.ENEMYONECHOICE;
                }
                else if (currentCharacter == battleStateStartScript.EnemyOne)
                {
                    currentState = BattleStates.ENEMYTWOCHOICE;
                }
                else if (currentCharacter == battleStateStartScript.EnemyTwo)
                {
                    currentState = BattleStates.ENEMYTHREECHOICE;
                }
                else if (currentCharacter == battleStateStartScript.EnemyThree)
                {
                    currentState = BattleStates.PLAYERCHOICE;
                }

                break;
            case (BattleStates.PLAYERANIMATE):
                break;
            case (BattleStates.ENEMYONECHOICE):
                currentCharacter = battleStateStartScript.EnemyOne;
                if (currentCharacter.Defeated)
                {
                    currentState = BattleStates.ENEMYTWOCHOICE;
                }
                else
                {
                    battleCalcScript.EnemyAi(currentCharacter);
                    currentState = BattleStates.ENEMYTWOCHOICE;
                }
                

                break;
            case (BattleStates.ENEMYTWOCHOICE):
                currentCharacter = battleStateStartScript.EnemyTwo;
                if (currentCharacter.Defeated)
                {
                    currentState = BattleStates.ENEMYTHREECHOICE;
                }
                else
                {
                    battleCalcScript.EnemyAi(currentCharacter);
                     currentState = BattleStates.ENEMYTHREECHOICE;
                }
                
                break;
            case (BattleStates.ENEMYTHREECHOICE):
                currentCharacter = battleStateStartScript.EnemyThree;
                if (currentCharacter.Defeated)
                {
                    currentState = BattleStates.PLAYERCHOICE;
                }
                else
                {
                    battleCalcScript.EnemyAi(currentCharacter);

                    currentState = BattleStates.PLAYERCHOICE;
                }
                
                break;
            case (BattleStates.ENEMYANIMATE):
                break;
            case (BattleStates.LOSE):
                Debug.Log("Lose");
                break;
            case (BattleStates.WIN):
                Debug.Log("Win");
                break;


        }
    }


    static public int WinLossCheck()
    {
        if(battleStateStartScript.EnemyOne.Defeated && battleStateStartScript.EnemyTwo.Defeated && battleStateStartScript.EnemyThree.Defeated)
        {
            
            return 2;
        }
        if (battleStateStartScript.MC.Defeated && battleStateStartScript.ratKing.Defeated && battleStateStartScript.nathan.Defeated)
        {
            return 1;
        }
        return 0;
    }


    //private void OnGUI()
    //{
    //    if(GUILayout.Button("NEXT STATE"))
    //    {
    //        if(currentState == BattleStates.START)
    //        {
    //            currentState = BattleStates.PLAYERCHOICE;
    //        }
    //        else if (currentState == BattleStates.PLAYERCHOICE)
    //        {
    //            currentState = BattleStates.PLAYERANIMATE;
    //        }
    //        else if (currentState == BattleStates.PLAYERANIMATE)
    //        {
    //            currentState = BattleStates.ENEMYCHOICE;
    //        }
    //        else if (currentState == BattleStates.ENEMYCHOICE)
    //        {
    //            currentState = BattleStates.ENEMYANIMATE;
    //        }
    //        else if (currentState == BattleStates.ENEMYANIMATE)
    //        {
    //            currentState = BattleStates.LOSE;
    //        }
    //        else if (currentState == BattleStates.LOSE)
    //        {
    //            currentState = BattleStates.WIN;
    //        }
    //        else if (currentState == BattleStates.WIN)
    //        {
    //            currentState = BattleStates.START;
    //        }
    //    }
    //}
}
