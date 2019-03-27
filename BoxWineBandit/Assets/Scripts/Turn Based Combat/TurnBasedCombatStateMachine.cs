using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour
{

    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        PLAYERANIMATE,
        ENEMYCHOICE,
        ENEMYANIMATE,
        LOSE,
        WIN
    }

    private BattleStates currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = BattleStates.START;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState);
        switch (currentState)
        {
            case (BattleStates.START) :
                break;
            case (BattleStates.PLAYERCHOICE):
                break;
            case (BattleStates.PLAYERANIMATE):
                break;
            case (BattleStates.ENEMYCHOICE):
                break;
            case (BattleStates.ENEMYANIMATE):
                break;
            case (BattleStates.LOSE):
                break;
            case (BattleStates.WIN):
                break;

        }
    }

    private void OnGUI()
    {
        if(GUILayout.Button("NEXT STATE"))
        {
            if(currentState == BattleStates.START)
            {
                currentState = BattleStates.PLAYERCHOICE;
            }
            else if (currentState == BattleStates.PLAYERCHOICE)
            {
                currentState = BattleStates.PLAYERANIMATE;
            }
            else if (currentState == BattleStates.PLAYERANIMATE)
            {
                currentState = BattleStates.ENEMYCHOICE;
            }
            else if (currentState == BattleStates.ENEMYCHOICE)
            {
                currentState = BattleStates.ENEMYANIMATE;
            }
            else if (currentState == BattleStates.ENEMYANIMATE)
            {
                currentState = BattleStates.LOSE;
            }
            else if (currentState == BattleStates.LOSE)
            {
                currentState = BattleStates.WIN;
            }
            else if (currentState == BattleStates.WIN)
            {
                currentState = BattleStates.START;
            }
        }
    }
}
