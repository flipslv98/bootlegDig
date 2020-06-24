using System.Collections.Generic;
using UnityEngine;

internal class Combatant 
{
    private Monster monster;
    private Buffs buffs;

    public Combatant(Monster m)
    {
        this.monster = m;
        buffs = new Buffs();
    }

    public float attackValue()
    {
        //buffs x monster attack
        return 0;
    }

    public float defenseValue()
    {
        //buffs x monster attack
        return 0;
    }
}