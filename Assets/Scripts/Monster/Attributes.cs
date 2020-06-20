using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attributes
{
    private readonly int MAX = 700;

    public int HP;
    public int MP;
    public int ATK;
    public int DEF;
    public int WIS;
    public int SPT;
    public int SPD;

    public Attributes(){}

    public void specificStart(System.Random r)
    {
        HP = r.Next(1,201);
        MP = r.Next(1,201);
        ATK = r.Next(1, 201);
        DEF = r.Next(1, 201);
        WIS = r.Next(1, 201);
        SPT = r.Next(1, 201);
        SPD = r.Next(1, 201);
    }

    public void trainedStart()
    {
        HP = 0;
        MP = 0;
        ATK = 0;
        DEF = 0;
        WIS = 0;
        SPT = 0;
        SPD = 0;
    }

    public int maxValues()
    {
        return HP + MP + ATK + DEF + WIS + SPT + SPD;
    }

    public void train(int[] values)
    {
        int max = maxValues();
        if(values[0] > 0 && max < MAX) HP += values[0];
        if(values[1] > 0 && max < MAX) MP += values[1];
        if(values[2] > 0 && max < MAX) ATK += values[2];
        if(values[3] > 0 && max < MAX) DEF += values[3];
        if(values[4] > 0 && max < MAX) WIS += values[4];
        if(values[5] > 0 && max < MAX) SPT += values[5];
        if(values[6] > 0 && max < MAX) SPD += values[6];
    }
}