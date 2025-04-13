public class GeologyLab : ResearchUnit
{
    private int m_numberOfGeodes;

    public GeologyLab(int oxygenLevel, int temperature, int numberOfWorkers, int numberOfGeodes) : base(oxygenLevel, temperature, numberOfWorkers)
    {
        m_numberOfGeodes = numberOfGeodes;
    }

    public void PrintInfo(){
        Console.WriteLine("Oxygen level: "+m_oxygenLevel);
        Console.WriteLine("Temperature: "+m_temperature);
        Console.WriteLine("workers: "+m_numberOfWorkers);
        Console.WriteLine("geodes: "+m_numberOfGeodes);
    }
}