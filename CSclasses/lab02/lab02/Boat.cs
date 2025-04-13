public class Boat : Vehicle
{
    public Boat() : base() { }
    public Boat(string engine, int maxVelocity) : base(engine, maxVelocity) { }

    public override string GetVehicleType()
    {
        return "boat";
    }
}