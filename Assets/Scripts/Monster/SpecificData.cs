using System;
using System.Collections.Generic;
using UnityEngine;
public class SpecificData : ScriptableObject
{
    public enum Size { PIGMY,TINY,SMALL,NORMAL,BIG,HUGE,COLOSSAL}

    public Attributes own;

    public int luck;
    public Size size;
    public List<Terrain.Type> standOn;

    public Attributes trained;

    public SpecificData(System.Random r)
    {
        luck = r.Next(1, 51);

        own = new Attributes();
        own.specificStart(r);

        trained = new Attributes();
        trained.trainedStart();

        Array v = Enum.GetValues(typeof(Size));
        size = (Size)v.GetValue(r.Next(v.Length));
    }

    public void train(int[] values)
    {
        trained.train(values);
    }
}