using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterData : ScriptableObject
{

    public enum Type
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
    protected int level;
    protected int exp;

    protected int hpMax;
    protected int mpMax;

    protected Attributes attributes;
    

       
}
