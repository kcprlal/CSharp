public class Program{
    static void Main(){
        // //Vehicle vehicle = new();
        Train train = new("electric", 117);
        // Vehicle trainAsVehicle = new Train("coal", 60);

        // //Console.WriteLine(vehicle.ToString());
        // Console.WriteLine(train.ToString());
        // Console.WriteLine(trainAsVehicle.ToString());

        List<Vehicle> myVehicles = new List<Vehicle>();
        myVehicles.Add(new Train("electric", 225));
        myVehicles.Add(new Bike("combustion", 313));
        myVehicles.Add(new Car("hybrid", 279));

        foreach(Vehicle v in myVehicles) Console.WriteLine(v);

        train.BuyTicket();
    }
}