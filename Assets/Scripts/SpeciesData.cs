using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SpeciesData", menuName = "Data/Species Data")]
public class SpeciesData : ScriptableObject
{

    [SerializeField] protected int baseHP;
    [SerializeField] protected int baseMP;
    [SerializeField] protected int baseATK;
    [SerializeField] protected int baseDEF;
    [SerializeField] protected int baseWIS;
    [SerializeField] protected int baseSPT;
    [SerializeField] protected int baseSPD;

    [SerializeField] protected int size;


}
