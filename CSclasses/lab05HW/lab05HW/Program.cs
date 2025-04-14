class Program
{
    static void Main(string[] args)
    {
        IceCreamFactory factory = new IceCreamFactory();
        IceCreamVendor vendor = new IceCreamVendor(factory);

        int[] schedule = [0, 1, 2, 3, 4, 5, 6];

        string[] days =
        [
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
        ];

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"\n--- {days[i]} ---");
            factory.SetProductionMode(schedule[i]);
            vendor.OfferSpecialOfTheDay();
        }
    }
}
