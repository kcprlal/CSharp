public class Medbay : ResearchUnit
{
    private int m_numberOfPatients;

    public Medbay(int oxygenLevel, int temperature, int numberOfWorkers, int numberOfPatients) : base(oxygenLevel, temperature, numberOfWorkers)
    {
        m_numberOfPatients = numberOfPatients;
    }

    public void PrintInfo(){
        Console.WriteLine("Oxygen level: "+m_oxygenLevel);
        Console.WriteLine("Temperature: "+m_temperature);
        Console.WriteLine("workers: "+m_numberOfWorkers);
        Console.WriteLine("patients: "+m_numberOfPatients);
    }
}