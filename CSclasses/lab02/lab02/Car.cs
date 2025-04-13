public class Car : Vehicle
{
    public Car() : base() { }
    public Car(string engine, int maxVelocity) : base(engine, maxVelocity) { }

    public override string GetVehicleType()
    {
        return "car";
    }
}