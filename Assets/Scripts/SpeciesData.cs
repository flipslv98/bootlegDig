using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SpeciesData", menuName = "Data/Species Data")]
public class SpeciesData : ScriptableObject
{

    [SerializeField] public int baseHP;
    [SerializeField] public int baseMP;
    [SerializeField] public int baseATK;
    [SerializeField] public int baseDEF;
    [SerializeField] public int baseWIS;
    [SerializeField] public int baseSPT;
    [SerializeField] public int baseSPD;

    [SerializeField] public int size;


}
