class CarFactory : VehicleFactory{
    private int id;
    public CarFactory(int id){
        this.id = id;
    }
    public override Vehicle Create(){
        List<string> brandList = ["honda", "audi", "bmw", "ford", "renault"];
        string brand = brandList[new Random().Next(0, 4)];
        Console.WriteLine("Car is created");
        return new Car("combustion", new Random().Next(180,330), brand, new Random().Next(2004,2022));
    }
}