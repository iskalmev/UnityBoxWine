using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart
{
    public BaseClass newEnemy;
    public BaseClass MC;


    public void PrepareBattle()
    {
        CreateMC();
        CreateNewEnemy();


    }

    private void CreateMC()
    {
        MC = new BaseBoxWineBandit();
    }

    private void CreateNewEnemy()
    {
        newEnemy = new BaseGator();
    }

    private void OnGUI()
    {
        GUI.Button(new Rect(Screen.width - 200, Screen.height - 50, 100, 30), newEnemy.AbilityOne.AbilityName);
    }
}
