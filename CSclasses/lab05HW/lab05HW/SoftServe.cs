using System.Security.Cryptography;

class SoftServe : IceCream
{
    private bool inCone;
    private bool chockSprink;
    public SoftServe(int price, string flavor, bool inCone, bool chockSprink)
    {
        this.price = price;
        mainFlavor = flavor;
        this.inCone = inCone;
        this.chockSprink = chockSprink;
    }
    public override void PrintDetails()
    {
        Console.WriteLine($"Soft serve ice cream - Flavor: {mainFlavor}, Price: {price}, In cone: {inCone}, Sprinkles: {chockSprink}");
    }
}