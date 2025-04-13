class TrainFactory : VehicleFactory{
    public override Vehicle Create(){
        Console.WriteLine("Train is created");
        return new Train("electric", new Random().Next(70,250));
    }
}