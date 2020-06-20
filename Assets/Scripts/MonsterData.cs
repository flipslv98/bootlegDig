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

    public Type type;
    public string name;
    public int level;
    public int exp;

    public int hpMax;
    public int mpMax;

    public Attributes attributes;
    

       
}
