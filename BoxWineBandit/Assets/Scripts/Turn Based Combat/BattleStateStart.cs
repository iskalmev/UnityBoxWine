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
        else if (fight == 4)
        {
            CreateFightFour();
        }
        else if (fight == 5)
        {
            CreateFightFive();
        }
        else if (fight == 6)
        {
            CreateFightSix();
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
        BattleGUI.textBoi.text = "";
        GameObject.Find("EnemyTwo").GetComponent<SpriteRenderer>().sprite = GameObject.Find("HurricaneHolder").GetComponent<SpriteRenderer>().sprite;
        MC.Power += 2;
        MC.Defense += 1;
        MC.CritChance += 3;
        MC.Health += 5;
        MC.MaxHealth += 5;
    }

    private void CreateFightThree()
    {
        MC = new BaseBoxWineBandit();
        ratKing = new BaseRatKing();
        nathan = new BaseNathan();
        EnemyOne = new BaseGator();
        EnemyTwo = new BaseBigMitch();
        EnemyThree = new BaseGator();
        BattleGUI.textBoi.text = "";
        GameObject.Find("EnemyTwo").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BigMitchHolder").GetComponent<SpriteRenderer>().sprite;
        MC.Power += 5;
        MC.Defense += 3;
        MC.CritChance += 8;
        MC.Health += 15;
        MC.MaxHealth += 15;
    }

    private void CreateFightFour()
    {
        MC = new BaseBoxWineBandit();
        ratKing = new BaseRatKing();
        nathan = new BaseNathan();
        EnemyOne = new BaseGator();
        EnemyTwo = new BaseMadoka();
        EnemyThree = new BaseGator();
        BattleGUI.textBoi.text = "";
        GameObject.Find("EnemyTwo").GetComponent<SpriteRenderer>().sprite = GameObject.Find("MadokaHolder").GetComponent<SpriteRenderer>().sprite;
        MC.Power += 10;
        MC.Defense += 6;
        MC.CritChance += 7;
        MC.Health += 25;
        MC.MaxHealth += 25;

    }

    private void CreateFightFive()
    {
        MC = new BaseBoxWineBandit();
        ratKing = new BaseRatKing();
        nathan = new BaseNathan();
        EnemyOne = new BaseGator();
        EnemyTwo = new BaseHeart();
        EnemyThree = new BaseGator();
        BattleGUI.textBoi.text = "";
        GameObject.Find("EnemyTwo").GetComponent<SpriteRenderer>().sprite = GameObject.Find("HeartHolder").GetComponent<SpriteRenderer>().sprite;

        MC.Power += 17;
        MC.Defense += 11;
        MC.CritChance += 15;
        MC.Health += 45;
        MC.MaxHealth += 45;
    }


    private void CreateFightSix()
    {
        MC = new BaseBoxWineBandit();
        ratKing = new BaseRatKing();
        nathan = new BaseNathan();
        
        EnemyTwo = new BaseFMM();
        EnemyOne = new phDefeated();
        EnemyThree = new phDefeated();
        BattleGUI.textBoi.text = "";
        GameObject.Find("EnemyTwo").GetComponent<SpriteRenderer>().sprite = GameObject.Find("FMMHolder").GetComponent<SpriteRenderer>().sprite;
        GameObject.Find("EnemyOne").GetComponent<SpriteRenderer>().sprite = GameObject.Find("FMMHolder").GetComponent<SpriteRenderer>().sprite;
        GameObject.Find("EnemyThree").GetComponent<SpriteRenderer>().sprite = GameObject.Find("FMMHolder").GetComponent<SpriteRenderer>().sprite;
        MC.Power += 100;
        MC.Defense += 100;
        MC.CritChance += 100;
        MC.Health += 100;
        MC.MaxHealth += 100;
    }



    //private void OnGUI()
    //{
    //    GUI.Button(new Rect(Screen.width - 200, Screen.height - 50, 100, 30), EnemyOne.AbilityOne.AbilityName);
    //}
}
