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
        DARK, 
        LIGHT,
        ENERGY, // SP EVIL+LIGHT
        VOID,
        COSMIC, // SP VOID+ENERGY
        FIRE,
        ROCK,
        LAVA, // SP FIRE+ROCK
        ICE,
        WIND,
        CRYSTAL, // SP ICE+WIND
        WATER,
        TOXIC,
        GRASS,
        ELETRIC,
        METAL,
        ARCANE,
        BRAWLER,
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
    // 
    protected int luck; // crit chance / dodge
       
}
