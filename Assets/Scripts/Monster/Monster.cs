using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected MonsterData monsterData;
    protected SpeciesData speciesData;
    protected SpecificData specificData;

    public Monster()
    {
        specificData = new SpecificData(new System.Random());
    }
   public int getSpeed()
   {
        return monsterData.attributes.SPD;
   }

    public int getLevel()
    {
        return monsterData.level;
    }
}
