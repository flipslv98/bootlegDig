using System;
using UnityEngine;
public class SpecificData : ScriptableObject
{
    public enum Size { PIGMY,TINY,SMALL,NORMAL,BIG,HUGE,COLOSSAL}

    protected Attributes specific;

    protected int luck;
    protected Size size;

    protected Attributes trained;

    public SpecificData(System.Random r)
    {
        luck = r.Next(1, 51);

        specific = new Attributes();
        specific.specificStart(r);

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