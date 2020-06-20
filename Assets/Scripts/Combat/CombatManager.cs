using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    private static CombatManager single_instance = null;

    public static CombatManager getInstance()
    {
        if (single_instance == null)
            single_instance = new CombatManager();

        return single_instance;
    }

    public static void combatPvE (Monster player, Monster enemy)
    {
        float speedRatio = 0;
        bool playerDead = false;
        bool enemyDead = false;
        bool playerDoubleAttack = false;
        bool enemyDoubleAttack = false;
        while (!playerDead && !enemyDead)
        {
            // receber input de ataque

            // calcular velocidades
            if (playerDoubleAttack)
            {
                // player.attack
                playerDoubleAttack = false;
            }
            else if (enemyDoubleAttack)
            {
                // enemy.attack
                enemyDoubleAttack = false;
            }
            else if (player.getSpeed() > enemy.getSpeed())
            {
                speedRatio = getSpeedRatio(player, enemy);            
            }
            else if (enemy.getSpeed() > player.getSpeed())
            {
                speedRatio = getSpeedRatio(enemy, player);
            }


        }

    }

    private static float getSpeedRatio(Monster faster, Monster slower)
    {
        float speedRatio = slower.getSpeed() * faster.getLevel() / faster.getSpeed() * slower.getLevel();
        speedRatio = 100 - speedRatio * 100;
        speedRatio = (float)Math.Round(speedRatio);
        System.Random r = new System.Random();
        int prob = r.Next(0, 100);
        if (prob < speedRatio)
        {
            // player.doubleattack
        }
        return speedRatio;
    }

    public static void combatPvP ()
    {

    }

}
