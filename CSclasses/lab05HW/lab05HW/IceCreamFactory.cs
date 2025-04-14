class IceCreamFactory
{
    private IceCreamType productionMode = IceCreamType.Special0;
    public IceCream SpecialOfTheDay()
    {
        return productionMode switch
        {
            IceCreamType.Special0 => new Cream(7, "chocolate", true, "cookie dough", true),
            IceCreamType.Special1 => new Cream(6, "vanilla", false, "whipped cream", true),
            IceCreamType.Special2 => new Fruit(8, "blueberry", true, "fruit"),
            IceCreamType.Special3 => new Fruit(9, "strawberry", false, "banana cream"),
            IceCreamType.Special4 => new SoftServe(4, "chocolate", true, false),
            IceCreamType.Special5 => new SoftServe(4, "vanilla", true, true),
            IceCreamType.Special6 => new Sorbet(3, "pineapple"),
            _ => new Sorbet(0, "null"),
        };
    }
    public void SetProductionMode(int i)
    {
        productionMode = (IceCreamType)i;
    }
}

enum IceCreamType
{
    Special0,
    Special1,
    Special2,
    Special3,
    Special4,
    Special5,
    Special6,
}