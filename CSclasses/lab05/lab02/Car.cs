public class Car : Vehicle
{
    private string brand="unknown";
    private int productionYear=0;
    public Car() : base() { }
    public Car(string engine, int maxVelocity, string brand, int productionYear) : base(engine, maxVelocity)
    {
        this.brand = brand;
        this.productionYear = productionYear;
    }

    public override string GetVehicleType()
    {
        return "car";
    }

    public override string ToString()
    {
        return $"Vehicle type: {GetVehicleType()}. Engine: {m_engine}. Velocity limit: {m_maxVelocity} km/h. Brand: {brand}, {productionYear}";
    }
}