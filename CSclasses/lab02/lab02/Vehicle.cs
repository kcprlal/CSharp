public abstract class Vehicle{
    protected string m_engine;
    protected int m_maxVelocity;

    public Vehicle(){
        m_engine = "unspecified";
        m_maxVelocity = 0;
    }
    public Vehicle(string engine, int maxVelocity){
        m_engine = engine;
        m_maxVelocity = maxVelocity;
    }
    public abstract string GetVehicleType();
    // {
    //     return "Unspecified vehicle";
    // }

    public override string ToString()
    {
        return $"Vehicle type: {GetVehicleType()}. Engine: {m_engine}. Velocity limit: {m_maxVelocity} km/h.";
    }
}

