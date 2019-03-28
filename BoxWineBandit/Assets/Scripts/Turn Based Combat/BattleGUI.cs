using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleGUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        if(TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE)
        {
            DisplayPlayerChoice();
        }else if (TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE)
        {
            DisplayEnemyChoice();
        }
        



    }

    private void DisplayPlayerChoice()
    {
        
        if (GUI.Button(new Rect(Screen.width - 100, Screen.height - 50, 150, 30), TurnBasedCombatStateMachine.battleStateStartScript.MC.AbilityOne.AbilityName))
        {
            TurnBasedCombatStateMachine.usedAbilty = TurnBasedCombatStateMachine.battleStateStartScript.MC.AbilityOne;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATEDAMAGE;
        }
    }


    //animation use only
    private void DisplayEnemyChoice()
    {
        if (GUI.Button(new Rect(Screen.width - 100, Screen.height - 50, 150, 30), TurnBasedCombatStateMachine.battleStateStartScript.newEnemy.AbilityOne.AbilityName))
        {
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATEDAMAGE;
        }
    }

}
