using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterData : ScriptableObject
{
    public enum Size
    {
        PIGMY,
        SMALL,
        MEDIUM,
        BIG,
        COLOSSAL
    }

    public enum Species
    {
        VOID, 
        DARK, 
        LIGHT,
        ENERGY, // SP VOID+EVIL+LIGHT
        FIRE, 
        TESTING__NAME, // SP FIRE+
        AIR,
        ICE,
        CRYSTAL, // SP ICE+WIND
        WATER,
        EARTH,
        ELETRIC,
        METAL,
        VENOM,
        ROCK,
        LAVA, // SP
        GRASS,
        NATURE, // SP GRASS+EARTH
        MENTAL,
        FIGHTER, 

    }

    protected Type type;
    protected string name;
    protected Size size;
    protected int level;
    protected int exp;

    protected int hp;
    protected int hpMax;
    protected int mp;
    protected int mpMax;

    protected int attack;
    protected int defense;
    protected int wisdom; // special attack
    protected int spirit; // special defense
    protected int speed; // quem da hit primeiro / dodge
    protected int luck; // crit chance / dodge
    
    

       
}
