class IceCreamVendor{
    private IceCreamFactory factory;
    
    public IceCreamVendor(IceCreamFactory factory)
    {
        this.factory = factory;
    }
    public void OfferSpecialOfTheDay(){
        IceCream iceCream = factory.SpecialOfTheDay();
        Console.WriteLine("Special of the day: ");
        iceCream.PrintDetails();
    }
}