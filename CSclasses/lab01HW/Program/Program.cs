using System;

class Program{
    static void Main(){
        Console.WriteLine("Quarter:");
        Quarter marsQuarter = new(78, 25, 15, "Marek Kowalski");
        marsQuarter.PrintInfo();

        Console.WriteLine("Park:");
        Park park = new(780, 2500, 1500, 34);
        park.PrintInfo();

        Console.WriteLine("medbay:");
        Medbay medbay = new(7, 225, 715, 23434);
        medbay.PrintInfo();

        Console.WriteLine("geology:");
        GeologyLab geolab = new(3378, 125, 23415, 34);
        geolab.PrintInfo();

        Console.WriteLine("atro:");
        AstronomyLab astro = new(2178, 4525, 115, 634);
        astro.PrintInfo();

        Console.WriteLine("garage:");
        Garage gar = new(11, 15, 35);
        gar.PrintInfo();
    }
}