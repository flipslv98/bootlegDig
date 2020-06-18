using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterData : ScriptableObject
{

    public enum Type
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
    protected int level;
    protected int exp;

    protected int hpMax;
    protected int mpMax;

    protected Attributes attributes;
    

       
}
