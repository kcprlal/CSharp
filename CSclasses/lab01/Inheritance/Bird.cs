using System;

public class Bird : Animal
{
    protected int m_feathers;

    public Bird(string name, int weight, int feathers) : base(name, weight)
    {
        m_feathers = feathers;
    }
    public Bird() : base()
    {
        m_feathers = 999;
    }
    public void PrintInfo()
    {
        Console.WriteLine(m_name + " weights " + m_weight + " and has " + m_feathers + " feathers");
    }

    public void LayEggs(int number)
    {
        Console.WriteLine($"{this.m_name} has layed {number} eggs");
    }
}