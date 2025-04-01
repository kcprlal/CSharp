using System;
public class Park : UsableArea
{
    private int m_numberOfTrees;

    public Park(int oxygenLevel, int temperature, int size, int numberOfTrees) : base(oxygenLevel, temperature, size)
    {
        m_numberOfTrees = numberOfTrees;
    }

    public void PrintInfo(){
        Console.WriteLine("Oxygen level: "+m_oxygenLevel);
        Console.WriteLine("Temperature: "+m_temperature);
        Console.WriteLine("Size of quarter: "+m_size);
        Console.WriteLine("Number of trees: "+m_numberOfTrees);
    }
}