using System;

public class Flamingo : Bird
{
    private string m_color;

    public Flamingo(string name, int weight, int feathers, string color) : base(name, weight, feathers)
    {
        m_color = color;
    }
    public Flamingo() : base(){
        m_color = "pink";
    }
    public new void PrintInfo()
    {
        Console.WriteLine($"{m_name} weighs {m_weight} and has {m_feathers} feathers of color {m_color}");
    }

    public void Incubation(int number, int days)
    {
        this.LayEggs(number);
        Console.WriteLine($"and they are incubated for {days} days");
    }
}