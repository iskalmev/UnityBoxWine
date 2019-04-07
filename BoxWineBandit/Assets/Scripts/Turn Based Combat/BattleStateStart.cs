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


    public void PrepareBattle(int fight)
    {

        if(fight == 1)
        {
            CreateFightOne();
        }
        else if(fight == 2)
        {
            CreateFightTwo();
        }
        else if (fight == 3)
        {
            CreateFightThree();
        }


    }


    private void CreateFightOne()
    {
        MC = new BaseBoxWineBandit();
        ratKing = new BaseRatKing();
        nathan = new BaseNathan();
        EnemyOne = new BaseGator();
        EnemyTwo = new BaseGator();
        EnemyThree = new BaseGator();

        
    }

    private void CreateFightTwo()
    {
        MC = new BaseBoxWineBandit();
        ratKing = new BaseRatKing();
        nathan = new BaseNathan();
        EnemyOne = new BaseGator();
        EnemyTwo = new BaseHurricane();
        EnemyThree = new BaseGator();

        GameObject.Find("EnemyTwo").GetComponent<SpriteRenderer>().sprite = GameObject.Find("HurricaneHolder").GetComponent<SpriteRenderer>().sprite;
    }

    private void CreateFightThree()
    {
        MC = new BaseBoxWineBandit();
        ratKing = new BaseRatKing();
        nathan = new BaseNathan();
        EnemyOne = new BaseGator();
        EnemyTwo = new BaseBigMitch();
        EnemyThree = new BaseGator();

        GameObject.Find("EnemyTwo").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BigMitchHolder").GetComponent<SpriteRenderer>().sprite;
    }



    //private void OnGUI()
    //{
    //    GUI.Button(new Rect(Screen.width - 200, Screen.height - 50, 100, 30), EnemyOne.AbilityOne.AbilityName);
    //}
}
