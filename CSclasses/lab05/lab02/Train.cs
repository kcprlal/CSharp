public class Train : Vehicle, IBuyTicket
{
    public Train() : base(){}
    public Train(string engine, int maxVelocity) : base(engine, maxVelocity){}
    public override string GetVehicleType()
    {
        return "train";
    }

    public void BuyTicket(){
        Console.WriteLine("Wow, you bought the ticket:)");
    }
    
}