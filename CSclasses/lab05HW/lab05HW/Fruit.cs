class Fruit : IceCream{
    private bool inCone;
    private string topping;
    public Fruit(int price, string flavor, bool inCone, string topping){
        this.price = price;
        mainFlavor = flavor;
        this.inCone = inCone;
        this.topping = topping;
    }
    public override void PrintDetails()
    {
        Console.WriteLine($"Fruit ice cream - Flavor: {mainFlavor}, Price: {price}, In cone: {inCone}, Topping: {topping}");
    }
}