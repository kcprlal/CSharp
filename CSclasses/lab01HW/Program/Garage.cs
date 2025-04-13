public class Garage : MartianBase
{
    private int m_numberOfVehicles;

    public Garage(int oxygenLevel, int temperature, int numberOfVehicles) : base(oxygenLevel, temperature)
    {
        m_numberOfVehicles = numberOfVehicles;
    }

    public void PrintInfo(){
        Console.WriteLine("Oxygen level: "+m_oxygenLevel);
        Console.WriteLine("Temperature: "+m_temperature);
        Console.WriteLine("vehicles: "+m_numberOfVehicles);
    }
}