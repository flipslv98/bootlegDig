using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    private static Terrain terrain;
    private static List<Combatant> side1;
    private static List<Combatant> side2;

    public static void combatPvE (Terrain t, Monster player, Monster enemy)
    {
        terrain = t;
        side1.Add(new Combatant(player));
        side2.Add(new Combatant(enemy));

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
