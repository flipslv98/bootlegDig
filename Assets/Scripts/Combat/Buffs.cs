internal class Buffs
{

    public Attributes atr;

    public Buffs()
    {
        atr = new Attributes(10,100);
    }

    public void changeStats(int[] values)
    {
        atr.add(values);
    }
}