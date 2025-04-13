class CarRentalService{
    private CarFactory car;
    public CarRentalService(int id){
        car = new CarFactory(id);
    }

    public void Rent(){
        Vehicle v = car.Create();
        Console.WriteLine("Our service can offer you the following car today: ");
        Console.WriteLine(v);
    }
}