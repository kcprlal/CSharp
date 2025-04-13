using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Bird bird1 = new("Marcel", 12, 23414);
            bird1.PrintInfo();
            bird1.LayEggs(7);

            Bird bird2 = new();
            bird2.PrintInfo();

            Flamingo flamingo1 = new("Kajetan", 14, 23231, "purple");
            flamingo1.PrintInfo();
            flamingo1.Incubation(2, 13);

            Flamingo flamingo2 = new();
            flamingo2.PrintInfo();
        }
    }

