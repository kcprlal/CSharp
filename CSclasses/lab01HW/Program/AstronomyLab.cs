public class AstronomyLab : ResearchUnit
{
    private int m_numberOfTelescopes;

    public AstronomyLab(int oxygenLevel, int temperature, int numberOfWorkers, int numberOfTelescopes) : base(oxygenLevel, temperature, numberOfWorkers)
    {
        m_numberOfTelescopes = numberOfTelescopes;
    }
    public void PrintInfo(){
        Console.WriteLine("Oxygen level: "+m_oxygenLevel);
        Console.WriteLine("Temperature: "+m_temperature);
        Console.WriteLine("workers: "+m_numberOfWorkers);
        Console.WriteLine("telscopes: "+m_numberOfTelescopes);
    }
}