using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour
{

    public static BattleStateStart battleStateStartScript = new BattleStateStart();
    public static BaseAbility usedAbilty;
    public static BaseClass currentCharacter;
    public static BaseClass targetCharacter;
    public static BattleCalculations battleCalcScript = new BattleCalculations();
    public static int fightCount = 1;
    public static int storyCount = 1;

    public bool attacking = false;
    public bool isBigMitch = false;


    public enum BattleStates
    {
        STORY,
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
        
        currentState = BattleStates.STORY;
        
        attacking = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!attacking)
        {
            StartCoroutine(WaitForEnemy());
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

    IEnumerator WaitForEnemy()
    {
        
            //Debug.Log(currentState);
            switch (currentState)
            {
                case (BattleStates.STORY):
                    if (storyCount == 1)
                    {
                        if (Story1Toggle.complete)
                        {
                            currentState = BattleStates.START;
                        }
                    }   
                    else if (storyCount == 2)
                    {
                    if (Story2Toggle.complete)
                    {
                        battleStateStartScript.PrepareBattle(fightCount);
                        currentState = BattleStates.PLAYERCHOICE;   
                    }
                    }
                else if (storyCount == 3)
                {
                    if (Story3Toggle.complete)
                    {
                        battleStateStartScript.PrepareBattle(fightCount);
                        currentState = BattleStates.PLAYERCHOICE;
                    }
                }
                else if (storyCount == 4)
                {
                    if (Story4Toggle.complete)
                    {
                        battleStateStartScript.PrepareBattle(fightCount);
                        currentState = BattleStates.PLAYERCHOICE;
                    }
                }
                else if (storyCount == 5)
                {
                    if (Story5Toggle.complete)
                    {
                        battleStateStartScript.PrepareBattle(fightCount);
                        currentState = BattleStates.PLAYERCHOICE;
                    }
                }
                if (storyCount == 6)
                {
                    if (Story6Toggle.complete)
                    {
                        battleStateStartScript.PrepareBattle(fightCount);
                        currentState = BattleStates.PLAYERCHOICE;
                    }
                }


                break;
                case (BattleStates.START):

                    battleStateStartScript.PrepareBattle(fightCount);
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
                    if (WinLossCheck() == 1)
                    {
                        currentState = BattleStates.LOSE;
                    }
                    else if (WinLossCheck() == 2)
                    {
                        currentState = BattleStates.WIN;
                    }
                    else if (currentCharacter == battleStateStartScript.MC)
                    {
                        currentState = BattleStates.ENEMYANIMATE;
                        BattleCalculations.playAnimation(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter, TurnBasedCombatStateMachine.usedAbilty);
                        attacking = true;
                       if (attacking)
                           {
                           yield return new WaitForSeconds(1.5f);
                        }
                    attacking = false;
                }
                    else if (currentCharacter == battleStateStartScript.ratKing)
                    {
                        currentState = BattleStates.ENEMYANIMATE;
                        BattleCalculations.playAnimation(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter, TurnBasedCombatStateMachine.usedAbilty);
                       attacking = true;
                       if (attacking)
                       {
                          yield return new WaitForSeconds(1.5f);
                       }
                    attacking = false;
                }
                    else if (currentCharacter == battleStateStartScript.nathan)
                    {
                        currentState = BattleStates.ENEMYANIMATE;
                        BattleCalculations.playAnimation(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter, TurnBasedCombatStateMachine.usedAbilty);
                         attacking = true;
                         if (attacking)
                          {
                                yield return new WaitForSeconds(2.5f);
                          }
                    attacking = false;
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
                        usedAbilty = battleStateStartScript.EnemyOne.AbilityOne;
                        currentState = BattleStates.ENEMYTWOCHOICE;
                        BattleCalculations.playAnimation(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter, TurnBasedCombatStateMachine.usedAbilty);
                        attacking = true;
                        if (attacking)
                        {
                            yield return new WaitForSeconds(2);
                        }
                        attacking = false;
                        
                    }
                    if (WinLossCheck() == 1)
                    {
                        currentState = BattleStates.LOSE;
                    }

                    break;
                case (BattleStates.ENEMYTWOCHOICE):
                    currentCharacter = battleStateStartScript.EnemyTwo;
                    if (currentCharacter.Defeated)
                    {
                        currentState = BattleStates.ENEMYANIMATE;
                    }
                    else
                    {
                        battleCalcScript.EnemyAi(currentCharacter);
                        usedAbilty = battleStateStartScript.EnemyTwo.AbilityOne;

                        currentState = BattleStates.ENEMYANIMATE;
                        BattleCalculations.playAnimation(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter, TurnBasedCombatStateMachine.usedAbilty);
                        attacking = true;
                        if (attacking)
                        {
                             if (isBigMitch)
                             {
                                 yield return new WaitForSeconds(4);
                             }
                             else
                             {
                                 yield return new WaitForSeconds(2);
                             }
                            
                        }
                        attacking = false;
                    }
                    if (WinLossCheck() == 1)
                    {
                        currentState = BattleStates.LOSE;
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
                        usedAbilty = battleStateStartScript.EnemyThree.AbilityOne;

                        currentState = BattleStates.ENEMYANIMATE;
                        BattleCalculations.playAnimation(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter, TurnBasedCombatStateMachine.usedAbilty);
                        attacking = true;
                        if (attacking)
                        {
                            yield return new WaitForSeconds(2);
                        }
                        attacking = false;
                    }
                    if (WinLossCheck() == 1)
                    {
                        currentState = BattleStates.LOSE;
                    }

                    break;
                case (BattleStates.ENEMYANIMATE):

                    if (currentCharacter == battleStateStartScript.MC)
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
                case (BattleStates.LOSE):
                    Debug.Log("Lose");
                    battleStateStartScript.PrepareBattle(fightCount);
                    currentState = BattleStates.PLAYERCHOICE;
                    break;
                case (BattleStates.WIN):
                    Debug.Log("Win");
                    storyCount += 1;
                    fightCount += 1;
                    if(fightCount == 3)
                     {
                       isBigMitch = true;
                     }
                    else
                    {
                        isBigMitch = false;
                    }
                    
                    currentState = BattleStates.STORY;
                    break;
            }
       


        
        

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
