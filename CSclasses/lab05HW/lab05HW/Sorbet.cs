class Sorbet : IceCream{
    public Sorbet(int price, string flavor){
        this.price = price;
        mainFlavor = flavor;
    }
    public override void PrintDetails()
    {
        Console.WriteLine($"Sorbet ice cream - Flavor: {mainFlavor}, Price: {price}");
    }
}