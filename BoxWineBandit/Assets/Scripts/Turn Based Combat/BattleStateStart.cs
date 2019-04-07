using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart
{
    
    public BaseClass EnemyOne;
    public BaseClass EnemyTwo;
    public BaseClass EnemyThree;
    public BaseClass MC;
    public BaseClass ratKing;
    public BaseClass nathan;


    public void PrepareBattle()
    {
        CreateMC();
        CreateNewEnemy();


    }

    private void CreateMC()
    {
        MC = new BaseBoxWineBandit();
        ratKing = new BaseRatKing();
        nathan = new BaseNathan();
    }

    private void CreateNewEnemy()
    {
        EnemyOne = new BaseGator();
        EnemyTwo = new BaseGator();
        EnemyThree = new BaseGator();
    }

    //private void OnGUI()
    //{
    //    GUI.Button(new Rect(Screen.width - 200, Screen.height - 50, 100, 30), EnemyOne.AbilityOne.AbilityName);
    //}
}
