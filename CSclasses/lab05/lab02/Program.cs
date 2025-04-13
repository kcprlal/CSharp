public class Program
{
    static void Main()
    {
        // List<VehicleFactory> factories = new List<VehicleFactory>() { new TrainFactory(), new CarFactory(5) };
        // foreach (VehicleFactory factory in factories)
        // {
        //     Vehicle v = factory.Create();
        //     Console.WriteLine(v);
        // }

        // CarRentalService c = new(5);
        // c.Rent();
        TransportFactory factory;

        Console.WriteLine("--- Urban transport ---");
        factory = new UrbanTransportFactory();
        factory.TravelMode = "quickest";
        var vehicle1 = factory.CreateVehicle();
        var ticket1 = factory.CreateTicket();
        Console.WriteLine($"Vehicle: {vehicle1.GetType().Name}, Ticket: {ticket1?.GetType().Name ?? "Null"}");
        Console.WriteLine("--- Intercity transport ---");
        factory = new IntercityTransportFactory();
        factory.TravelMode = "quickest";
        var vehicle2 = factory.CreateVehicle();
        var ticket2 = factory.CreateTicket();
        Console.WriteLine($"Vehicle: {vehicle2.GetType().Name}, Ticket: {ticket2?.GetType().Name ?? "Null"}");
    }
}