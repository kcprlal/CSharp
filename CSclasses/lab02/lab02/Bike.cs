public class Bike : Vehicle
{
    public Bike() : base() { }
    public Bike(string engine, int maxVelocity) : base(engine, maxVelocity) { }

    public override string GetVehicleType()
    {
        return "bike";
    }
}