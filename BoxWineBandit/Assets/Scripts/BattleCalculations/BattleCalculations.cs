using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCalculations
{

    bool miss = false;


    public void CalculateUsedAbilityDamage(BaseAbility usedAbility)
    {
        if (usedAbility.AbilityType == 1)
        {
            CalculateAbilityDamage(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter);
        }
        else if (usedAbility.AbilityType == 2)
        {
            CalculateAbilityHealing(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter);
        }
        else if (usedAbility.AbilityType == 3)
        {
            CalculateAbilityTankBuff(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter);
        }
        else if (usedAbility.AbilityType == 4)
        {
            CalculateAbilityMiss(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter);
        }
        else if (usedAbility.AbilityType == 5)
        {
            CalculateAbilitySiphon(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter);
        }
        else if (usedAbility.AbilityType == 6)
        {
            CalculateAbilityRend(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter);
        }


        //Debug.Log("before Anim");
        //playAnimation(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter, usedAbility);
        //Debug.Log("afterAnim");

    }


    public void EnemyAi(BaseClass enemy)
    {
        float randomNumber = (Random.value * 3);
        if (randomNumber < 1)
        {
            if (TurnBasedCombatStateMachine.battleStateStartScript.MC.Defeated)
            {
                if (TurnBasedCombatStateMachine.battleStateStartScript.ratKing.Defeated)
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan);
                    TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.nathan;
                    //playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan, enemy.AbilityOne);
                }
                else
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing);
                    TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.ratKing;
                    //playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing, enemy.AbilityOne);
                }

            }
            else
            {
                CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC);
                TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.MC;
                //playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC, enemy.AbilityOne);


            }

        }
        else if (randomNumber < 2)
        {
            if (TurnBasedCombatStateMachine.battleStateStartScript.ratKing.Defeated)
            {
                if (TurnBasedCombatStateMachine.battleStateStartScript.nathan.Defeated)
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC);
                    TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.MC;
                    //playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC, enemy.AbilityOne);

                }
                else
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan);
                    TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.nathan;
                    //playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan, enemy.AbilityOne);
                }

            }
            else
            {
                CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing);
                TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.ratKing;
                //playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing, enemy.AbilityOne);

            }

        }
        else if (randomNumber < 3)
        {
            if (TurnBasedCombatStateMachine.battleStateStartScript.nathan.Defeated)
            {
                if (TurnBasedCombatStateMachine.battleStateStartScript.MC.Defeated)
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing);
                    TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.ratKing;
                    //playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing, enemy.AbilityOne);

                }
                else
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC);
                    TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.MC;
                    //playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC, enemy.AbilityOne);


                }

            }
            else
            {
                CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan);
                TurnBasedCombatStateMachine.targetCharacter = TurnBasedCombatStateMachine.battleStateStartScript.nathan;
                //playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan, enemy.AbilityOne);
            }

        }

        


    }



    private void CalculateAbilityHealing(BaseClass attacker, BaseClass defender)
    {
        float randomNumber = (Random.value * 100);

        if (attacker.HitChance > randomNumber)
        {
            miss = false;
            if (attacker.CritChance > randomNumber)
            {
                if (defender.Defense > 0)
                {
                    defender.Health += attacker.Power + defender.Defense;
                
                    BattleGUI.textBoi.text = attacker.CharacterClassName + " critically healed " + defender.CharacterClassName + " for " + (attacker.Power + defender.Defense) + " health";
                }
                else
                {
                    defender.Health += attacker.Power;

                    BattleGUI.textBoi.text = attacker.CharacterClassName + " critically healed " + defender.CharacterClassName + " for " + (attacker.Power) + " health";
                }
                


                if (defender.Health > defender.MaxHealth)
                {
                    defender.Health = defender.MaxHealth;
                }
            }
            else
            {
                defender.Health += attacker.Power;
                defender.Defense -= attacker.Power / 8;
                BattleGUI.textBoi.text = attacker.CharacterClassName + " healed " + defender.CharacterClassName + " for " + (attacker.Power) + " health while reducing his defense by " + (attacker.Power / 8);

                if (defender.Health > defender.MaxHealth)
                {
                    defender.Health = defender.MaxHealth;
                }
            }



            
        }
        else
        {
            BattleGUI.textBoi.text = attacker.CharacterClassName + " missed healing " + defender.CharacterClassName + ".";
            miss = true;
        }
    }


    private void CalculateAbilityDamage(BaseClass attacker, BaseClass defender)
    {
        
        float randomNumber = (Random.value * 100);

        if(attacker.HitChance > randomNumber)
        {
            miss = false;
            if (attacker.CritChance > randomNumber)
            {
                if (defender.Defense < 0)
                {
                    defender.Health -= (attacker.Power - defender.Defense) * 2;
                    BattleGUI.textBoi.text = attacker.CharacterClassName + " critically damaged " + defender.CharacterClassName + " for " + (attacker.Power - defender.Defense + attacker.Defense) + " damage.";
                }
                else
                {
                    defender.Health -= attacker.Power * 2;
                    BattleGUI.textBoi.text = attacker.CharacterClassName + " critically damaged " + defender.CharacterClassName + " for " + (attacker.Power) + " damage.";

                }
                
            }
            else
            {
                if (attacker.Power > defender.Defense)
                {
                    defender.Health -= attacker.Power - defender.Defense;
                    BattleGUI.textBoi.text = attacker.CharacterClassName + " damaged " + defender.CharacterClassName + " for " + (attacker.Power - defender.Defense) + " damage.";
                }
                else
                {
                    defender.Health -= 1;
                    BattleGUI.textBoi.text = attacker.CharacterClassName + " barely damaged " + defender.CharacterClassName + " for 1 damage.";

                }

            }
            
            if (defender.Health < 1)
            {
                defender.Defeated = true;
                BattleGUI.textBoi.text += " The hit caused " + defender.CharacterClassName + " to be defeated";
            }

            
            Debug.Log("Current Health: " + defender.Health);
            
            //if (defender == TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne)
            //{
            //    BattleGUI.EnemyOneImage.fillAmount = (float)(defender.Health) / (float)(defender.MaxHealth);
            //}

        }
        else
        {
            BattleGUI.textBoi.text = attacker.CharacterClassName + " missed damaging " + defender.CharacterClassName + ".";
            miss = true;
        }


    }

    private void CalculateAbilityMiss(BaseClass attacker, BaseClass defender)
    {

        float randomNumber = (Random.value * 100);

        if (attacker.HitChance > randomNumber)
        {
            miss = false;
            if (attacker.CritChance > randomNumber)
            {
                defender.HitChance -= attacker.Power / 3 * 2;
                BattleGUI.textBoi.text = attacker.CharacterClassName + " critically reduced " + defender.CharacterClassName + "'s hitchance by " + attacker.Power / 3 * 2 + "%";
                if (defender.HitChance < 15)
                {
                    defender.HitChance = 15;
                    BattleGUI.textBoi.text += " and it won't go any lower.";
                }
                else
                {
                    BattleGUI.textBoi.text += ".";
                }
            }
            else
            {
                defender.HitChance -= attacker.Power / 3;
                BattleGUI.textBoi.text = attacker.CharacterClassName + " reduced " + defender.CharacterClassName + "'s hitchance by " + attacker.Power / 3 + "%";
                if (defender.HitChance < 15)
                {
                    defender.HitChance = 15;
                    BattleGUI.textBoi.text += " and it won't go any lower.";
                }
                else
                {
                    BattleGUI.textBoi.text += ".";
                }
            }



        }
        else
        {
            BattleGUI.textBoi.text = attacker.CharacterClassName + " missed reducing " + defender.CharacterClassName + "'s hitchance.";
            miss = true;
        }

    }

    private void CalculateAbilityTankBuff(BaseClass attacker, BaseClass defender)
    {

        float randomNumber = (Random.value * 100);

        if (attacker.HitChance > randomNumber)
        {
            miss = false;
            defender.CritChance += 18;
            
            BattleGUI.textBoi.text = attacker.CharacterClassName + " increased " + defender.CharacterClassName + "'s crit chance by 18%";
            if (defender.CritChance > 94)
            {
                
                BattleGUI.textBoi.text += " and it can't go any higher.";
                defender.CritChance = 95;
            }
            else
            {
                BattleGUI.textBoi.text += ".";
            }


        }
        else
        {
            BattleGUI.textBoi.text = attacker.CharacterClassName + " missed buffing " + defender.CharacterClassName + ".";
            miss = true;
        }


    }


    private void CalculateAbilitySiphon(BaseClass attacker, BaseClass defender)
    {

        float randomNumber = (Random.value * 100);

        if (attacker.HitChance > randomNumber)
        {
            miss = false;
            if (attacker.CritChance > randomNumber)
            {
                defender.Health -= (attacker.Power - defender.Defense) * 2;
                attacker.Health += attacker.Power - defender.Defense;
                BattleGUI.textBoi.text = attacker.CharacterClassName + " critically damaged " + defender.CharacterClassName + " for " + ((attacker.Power - defender.Defense) * 2) + " damage while healing himself for " + (attacker.Power - defender.Defense);
            }
            else
            {
                defender.Health -= attacker.Power - defender.Defense;
                attacker.Health += (attacker.Power - defender.Defense) / 2;
                BattleGUI.textBoi.text = attacker.CharacterClassName + " damaged " + defender.CharacterClassName + " for " + (attacker.Power - defender.Defense) + " damage while healing himself for " + (attacker.Power - defender.Defense) / 2;
            }

            if (defender.Health < 1)
            {
                defender.Defeated = true;
                BattleGUI.textBoi.text += " The hit caused " + defender.CharacterClassName + " to be defeated";
            }
            if(attacker.Health > attacker.MaxHealth)
            {
                attacker.Health = attacker.MaxHealth;
            }


            Debug.Log("Current Health: " + defender.Health);

            //if (defender == TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne)
            //{
            //    BattleGUI.EnemyOneImage.fillAmount = (float)(defender.Health) / (float)(defender.MaxHealth);
            //}

        }
        else
        {
            BattleGUI.textBoi.text = attacker.CharacterClassName + " missed damaging " + defender.CharacterClassName + ".";
            miss = true;
        }


    }


    private void CalculateAbilityRend(BaseClass attacker, BaseClass defender)
    {

        float randomNumber = (Random.value * 100);

        if (attacker.HitChance > randomNumber)
        {
            miss = false;
            if (attacker.CritChance > randomNumber)
            {
                defender.Health -= attacker.Power;
                defender.Defense -= attacker.Power / 3;
                BattleGUI.textBoi.text = attacker.CharacterClassName + " critically damaged " + defender.CharacterClassName + " for " + (attacker.Power) + " damage while reducing their defense for " + (attacker.Power / 3);
            }
            else
            {
                defender.Health -= attacker.Power - defender.Defense;
                defender.Defense -= attacker.Power / 6;
                BattleGUI.textBoi.text = attacker.CharacterClassName + " damaged " + defender.CharacterClassName + " for " + (attacker.Power - defender.Defense) + " damage while reducing their defense for " + attacker.Power / 6;
            }

            if (defender.Health < 1)
            {
                defender.Defeated = true;
                BattleGUI.textBoi.text += " The hit caused " + defender.CharacterClassName + " to be defeated";
            }
            
            Debug.Log("Current Health: " + defender.Health);

            //if (defender == TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne)
            //{
            //    BattleGUI.EnemyOneImage.fillAmount = (float)(defender.Health) / (float)(defender.MaxHealth);
            //}

        }
        else
        {
            BattleGUI.textBoi.text = attacker.CharacterClassName + " missed damaging " + defender.CharacterClassName + ".";
            miss = true;
        }


    }

    public static void playAnimation(BaseClass source, BaseClass target, BaseAbility ability)
    {
        UnityEngine.GameObject sour;
        UnityEngine.GameObject tar;
        //ADDED THIS VARIABLE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        GameObject abil;


        if(source == TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne)
        {
            sour = GameObject.Find("EnemyOne").gameObject;
        }
        else if (source == TurnBasedCombatStateMachine.battleStateStartScript.EnemyTwo)
        {
            sour = GameObject.Find("EnemyTwo").gameObject;
        }
        else if (source == TurnBasedCombatStateMachine.battleStateStartScript.EnemyThree)
        {
            sour = GameObject.Find("EnemyThree").gameObject;
        }
        else if (source == TurnBasedCombatStateMachine.battleStateStartScript.MC)
        {
            sour = GameObject.Find("Mitch").gameObject;
        }
        else if (source == TurnBasedCombatStateMachine.battleStateStartScript.ratKing)
        {
            sour = GameObject.Find("RatKing").gameObject;
        }
        else //(source == TurnBasedCombatStateMachine.battleStateStartScript.nathan)
        {
            sour = GameObject.Find("Nathan").gameObject;
        }





        if (target == TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne)
        {
            tar = GameObject.Find("EnemyOne").gameObject;
        }
        else if (target == TurnBasedCombatStateMachine.battleStateStartScript.EnemyTwo)
        {
            tar = GameObject.Find("EnemyTwo").gameObject;
        }
        else if (target == TurnBasedCombatStateMachine.battleStateStartScript.EnemyThree)
        {
            tar = GameObject.Find("EnemyThree").gameObject;
        }
        else if (target == TurnBasedCombatStateMachine.battleStateStartScript.MC)
        {
            tar = GameObject.Find("Mitch").gameObject;
        }
        else if (target == TurnBasedCombatStateMachine.battleStateStartScript.ratKing)
        {
            tar = GameObject.Find("RatKing").gameObject;
        }
        else //(target == TurnBasedCombatStateMachine.battleStateStartScript.nathan)
        {
            tar = GameObject.Find("Nathan").gameObject;
        }



        //aDDED THIS SHIT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        if (!TurnBasedCombatStateMachine.battleCalcScript.miss)
        {


            if (ability.AbilityName == "Gator Bite")
            {

                GameObject theGatorAttack = GameObject.Find("GatorBite0000").gameObject;
                GatorBite playerScript = theGatorAttack.GetComponent<GatorBite>();
                Debug.Log("BIG GATOR ATTACK");
                //tar.transform.position = tar.transform.position + new Vector3(10, 10, 0);
                playerScript.getInfo(tar, sour, theGatorAttack);


                //abil.GetComponent<GatorBite>().getInfo(tar, sour);

            }
            else if (ability.AbilityName == "Rat Throw")
            {
                GameObject theAttack = GameObject.Find("RatProjectileTrans").gameObject;
                RatThrow playerScript = theAttack.GetComponent<RatThrow>();
                playerScript.getInfo(tar, sour);
            }
            else if (ability.AbilityName == "Rat Wall")
            {
                GameObject theAttack = GameObject.Find("RatWall0002").gameObject;
                RatWall playerScript = theAttack.GetComponent<RatWall>();
                playerScript.getInfo(tar, sour);
            }
            else if (ability.AbilityName == "Steal Cat")
            {
                GameObject theAttack = GameObject.Find("cat").gameObject;
                StealCat playerScript = theAttack.GetComponent<StealCat>();
                playerScript.getInfo(tar, sour);
            }
            else if (ability.AbilityName == "Spill Ranch")
            {
                GameObject theAttack = GameObject.Find("RatProjectileTrans").gameObject;
                RatThrow playerScript = theAttack.GetComponent<RatThrow>();
                playerScript.getInfo(tar, sour);
            }
            else if (ability.AbilityName == "Cinder Strike")
            {
                GameObject theAttack = GameObject.Find("MitchAttack0008 (1)").gameObject;
                MitchAttack playerScript = theAttack.GetComponent<MitchAttack>();
                playerScript.getInfo(tar, sour);
            }
            else if (ability.AbilityName == "Box Wine")
            {
                GameObject theAttack = GameObject.Find("RedBoxWine").gameObject;
                BoxWine playerScript = theAttack.GetComponent<BoxWine>();
                playerScript.getInfo(tar, sour);
            }
            else if (ability.AbilityName == "Airblast")
            {
                GameObject theAttack = GameObject.Find("BasicWindAttack0003").gameObject;
                BasicWindAttack playerScript = theAttack.GetComponent<BasicWindAttack>();
                playerScript.getInfo(tar, sour);
            }
            else if (ability.AbilityName == "Stomp")
            {
                GameObject theAttack = GameObject.Find("boot").gameObject;
                Boot playerScript = theAttack.GetComponent<Boot>();
                playerScript.getInfo(tar, sour);
            }
            else
            {
                ability.UseAbility(tar, sour);
                Debug.Log("BIG LAME ATTACK");
            }
        }


        
        






    }


 

}
