using System.ComponentModel;

class Cream : IceCream
{
    private bool inCone;
    private string topping;
    private bool chockSprink;
    public Cream(int price, string flavor, bool inCone, string topping, bool chockSprink)
    {
        this.price = price;
        mainFlavor = flavor;
        this.inCone = inCone;
        this.topping = topping;
        this.chockSprink = chockSprink;
    }
    public override void PrintDetails()
    {
        Console.WriteLine($"Cream ice cream - Flavor: {mainFlavor}, Price: {price}, In cone: {inCone}, Sprinkles: {chockSprink}, Topping: {topping}");
    }
}