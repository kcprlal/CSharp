public class Quarter : UsableArea
{
    private string m_habitant;

    public Quarter(int oxygenLevel, int temperature, int size, string habitant) : base(oxygenLevel, temperature, size)
    {
        m_habitant = habitant;
    }

    //funkcja testowa
    public void PrintInfo(){
        Console.WriteLine("Oxygen level: "+m_oxygenLevel);
        Console.WriteLine("Temperature: "+m_temperature);
        Console.WriteLine("Size of quarter: "+m_size);
        Console.WriteLine("habitant: "+m_habitant);
    }
}