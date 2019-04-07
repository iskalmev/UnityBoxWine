using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCalculations
{

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

        Debug.Log("before Anim");
        playAnimation(TurnBasedCombatStateMachine.currentCharacter, TurnBasedCombatStateMachine.targetCharacter, usedAbility);
        Debug.Log("afterAnim");

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
                    playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan, enemy.AbilityOne);
                }
                else
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing);
                    playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing, enemy.AbilityOne);
                }

            }
            else
            {
                CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC);
                playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC, enemy.AbilityOne);


            }

        }
        else if (randomNumber < 2)
        {
            if (TurnBasedCombatStateMachine.battleStateStartScript.ratKing.Defeated)
            {
                if (TurnBasedCombatStateMachine.battleStateStartScript.nathan.Defeated)
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC);
                    playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC, enemy.AbilityOne);

                }
                else
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan);
                    playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan, enemy.AbilityOne);
                }

            }
            else
            {
                CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing);
                playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing, enemy.AbilityOne);

            }

        }
        else if (randomNumber < 3)
        {
            if (TurnBasedCombatStateMachine.battleStateStartScript.nathan.Defeated)
            {
                if (TurnBasedCombatStateMachine.battleStateStartScript.MC.Defeated)
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing);
                    playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.ratKing, enemy.AbilityOne);

                }
                else
                {
                    CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC);
                    playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.MC, enemy.AbilityOne);


                }

            }
            else
            {
                CalculateAbilityDamage(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan);
                playAnimation(enemy, TurnBasedCombatStateMachine.battleStateStartScript.nathan, enemy.AbilityOne);
            }

        }

        


    }



    private void CalculateAbilityHealing(BaseClass attacker, BaseClass defender)
    {
        float randomNumber = (Random.value * 100);

        if (attacker.HitChance > randomNumber)
        {
            if (attacker.CritChance > randomNumber)
            {
                defender.Health += attacker.Power + defender.Defense;
                if(defender.Health > defender.MaxHealth)
                {
                    defender.Health = defender.MaxHealth;
                }
            }
            else
            {
                defender.Health += attacker.Power;
                if (defender.Health > defender.MaxHealth)
                {
                    defender.Health = defender.MaxHealth;
                }
            }

            


        }
    }


    private void CalculateAbilityDamage(BaseClass attacker, BaseClass defender)
    {
        
        float randomNumber = (Random.value * 100);

        if(attacker.HitChance > randomNumber)
        {
            if (attacker.CritChance > randomNumber)
            {
                defender.Health -= attacker.Power;
            }
            else
            {
                defender.Health -= attacker.Power - defender.Defense;
            }
            
            if (defender.Health < 1)
            {
                defender.Defeated = true;
            }

            
            Debug.Log("Current Health: " + defender.Health);
            
            //if (defender == TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne)
            //{
            //    BattleGUI.EnemyOneImage.fillAmount = (float)(defender.Health) / (float)(defender.MaxHealth);
            //}

        }
        else
        {
            Debug.Log("Miss");
        }


    }

    private void CalculateAbilityMiss(BaseClass attacker, BaseClass defender)
    {

        float randomNumber = (Random.value * 100);

        if (attacker.HitChance > randomNumber)
        {
            if (attacker.CritChance > randomNumber)
            {
                defender.HitChance -= attacker.Power * 4;
                if(defender.HitChance < 30)
                {
                    defender.HitChance = 30;
                }
            }
            else
            {
                defender.HitChance -= attacker.Power - defender.Defense * 4;
                if (defender.HitChance < 25)
                {
                    defender.HitChance = 25;
                }
            }



        }

    }

    private void CalculateAbilityTankBuff(BaseClass attacker, BaseClass defender)
    {

        float randomNumber = (Random.value * 100);

        if (attacker.HitChance > randomNumber)
        {
            
            defender.Defense += 1;
            defender.HitChance -= 15;
            if (defender.HitChance < 25)
            {
                defender.HitChance = 25;
                defender.Defense -= 1;
            }
            



        }
        

    }


    private void playAnimation(BaseClass source, BaseClass target, BaseAbility ability)
    {
        UnityEngine.GameObject sour;
        UnityEngine.GameObject tar;
        //ADDED THIS VARIABLE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        GameObject abil;


        if(source == TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne)
        {
            sour = BattleGUI.EnemyOneOb;
        }
        else if (source == TurnBasedCombatStateMachine.battleStateStartScript.EnemyTwo)
        {
            sour = BattleGUI.EnemyTwoOb;
        }
        else if (source == TurnBasedCombatStateMachine.battleStateStartScript.EnemyThree)
        {
            sour = BattleGUI.EnemyThreeOb;
        }
        else if (source == TurnBasedCombatStateMachine.battleStateStartScript.MC)
        {
            sour = BattleGUI.MCOb;
        }
        else if (source == TurnBasedCombatStateMachine.battleStateStartScript.ratKing)
        {
            sour = BattleGUI.RatKingOb;
        }
        else //(source == TurnBasedCombatStateMachine.battleStateStartScript.nathan)
        {
            sour = BattleGUI.NathanOb;
        }





        if (target == TurnBasedCombatStateMachine.battleStateStartScript.EnemyOne)
        {
            tar = BattleGUI.EnemyOneOb;
        }
        else if (target == TurnBasedCombatStateMachine.battleStateStartScript.EnemyTwo)
        {
            tar = BattleGUI.EnemyTwoOb;
        }
        else if (target == TurnBasedCombatStateMachine.battleStateStartScript.EnemyThree)
        {
            tar = BattleGUI.EnemyThreeOb;
        }
        else if (target == TurnBasedCombatStateMachine.battleStateStartScript.MC)
        {
            tar = BattleGUI.MCOb;
        }
        else if (target == TurnBasedCombatStateMachine.battleStateStartScript.ratKing)
        {
            tar = BattleGUI.RatKingOb;
        }
        else //(target == TurnBasedCombatStateMachine.battleStateStartScript.nathan)
        {
            tar = BattleGUI.NathanOb;
        }



        //aDDED THIS SHIT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        if(ability.AbilityName == "Gator Bite")
        {
            abil = BattleGUI.gatorBite;
            Debug.Log("BIG GATOR ATTACK");
            abil.GetComponent<GatorBite>().getInfo(tar, sour);
            
        }
        else
        {
            ability.UseAbility(tar, sour);
            Debug.Log("BIG LAME ATTACK");
        }




        
       

    }


}
