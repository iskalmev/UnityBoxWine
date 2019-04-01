using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour
{

    private BaseCharacter boxWineBandit;
    


    private void Start()
    {
        boxWineBandit = new BaseCharacter();
        boxWineBandit.PlayerClass = new BaseBoxWineBandit();

        boxWineBandit.PlayerLevel = 1;
        boxWineBandit.Power = boxWineBandit.PlayerClass.Power;
        boxWineBandit.HitChance = boxWineBandit.PlayerClass.HitChance;
        boxWineBandit.CritChance = boxWineBandit.PlayerClass.CritChance;
        boxWineBandit.Health = boxWineBandit.PlayerClass.Health;
        boxWineBandit.Defense = boxWineBandit.PlayerClass.Defense;
        StoreNewPlayerInfo();

        
    }

    private void Update()
    {

    }

    private void OnGUI()
    {
        //if (GUILayout.Button("Load"))
        //{
        //    UnityEngine.SceneManagement.SceneManager.LoadScene("test");

        //}


        //if (GUILayout.Button("Create"))
        //{
        //    boxWineBandit.PlayerClass = new BaseBoxWineBandit();

        //    boxWineBandit.PlayerLevel = 1;
        //    boxWineBandit.Power = boxWineBandit.PlayerClass.Power;
        //    boxWineBandit.HitChance = boxWineBandit.PlayerClass.HitChance;
        //    boxWineBandit.CritChance = boxWineBandit.PlayerClass.CritChance;
        //    boxWineBandit.Health = boxWineBandit.PlayerClass.Health;
        //    boxWineBandit.Defense = boxWineBandit.PlayerClass.Defense;
        //    SaveInformation.SaveAllInformation();


        //    Debug.Log("Player Level: " + newPlayer.PlayerLevel);
        //    Debug.Log("Player Power: " + newPlayer.Power);
        //    Debug.Log("Player Hit Chance: " + newPlayer.HitChance);
        //    Debug.Log("Player Critical Chance: " + newPlayer.CritChance);
        //    Debug.Log("Player Health: " + newPlayer.Health);
        //    Debug.Log("Player Defense: " + newPlayer.Defense);
        //    Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
        //}
    }

    private void StoreNewPlayerInfo()
    {
        GameInformation.BoxWineBandit = boxWineBandit;
    }

}
