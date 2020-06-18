using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public static class CombatManager : MonoBehaviour
{
    private static CombatManager single_instance = null;

    public static CombatManager getInstance()
    {
        if (single_instance == null)
            single_instance = new CombatManager();

        return single_instance;
    }

    public static combatPvE (Monster player, Monster enemy)
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
                speedRatio = getSpeedRatio(player.getSpeed(), enemy.getSpeed());            
            }
            else if (enemy.getSpeed() > player.getSpeed())
            {
                speedRatio = getSpeedRatio(enemy.getSpeed(), player.getSpeed());
            }


        }

    }

    private float getSpeedRatio(int faster, int slower)
    {
        speedRatio = enemy.getSpeed() * player.getLevel() / player.getSpeed() * enemy.getLevel();
        speedRatio = 100 - speedRatio * 100;
        speedRatio = Math.Round(speedRatio);
        Random r = new Random();
        int prob = r.next(0, 100);
        if (prob < speedRatio)
        {
            // player.doubleattack
        }
    }

    public static combatPvP ()
    {

    }

}
