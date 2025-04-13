public class Program
{
    public static void Main()
    {
        int humanCost = 0, roboCost = 0;
        var physicalWorker1 = new PhysicalWorker("Jurek", 101);
        var physicalWorker2 = new PhysicalWorker("Andzia", 102);
        var physicalWorker3 = new PhysicalWorker("Marek", 103);

        var officeWorker1 = new OfficeWorker("Józefina", 201, true);
        var officeWorker2 = new OfficeWorker("Karol", 202, false);
        var officeWorker3 = new OfficeWorker("Krzysiek", 203, true);

        var mechanicalRobot1 = new MechanicalRobot("ROBert", 301);
        var mechanicalRobot2 = new MechanicalRobot("alejanDRON", 302);
        var mechanicalRobot3 = new MechanicalRobot("MarCELL", 303);

        var computer1 = new Computer("COMrad", 401, true);
        var computer2 = new Computer("Stefan", 402, false);
        var computer3 = new Computer("Kazek", 403, true);

        List<Human> allHumans = [];
        List<Robot> allRobots = [];
        List<IInternetConnection> needInternet = [];

        allHumans.AddRange(physicalWorker1, physicalWorker2, physicalWorker3,
                            officeWorker1, officeWorker2, officeWorker3);

        allRobots.AddRange(mechanicalRobot1, mechanicalRobot2, mechanicalRobot3,
                            computer1, computer2, computer3);

        needInternet.AddRange(officeWorker1, officeWorker2, officeWorker3,
                            computer1, computer2, computer3);

        foreach (var h in allHumans)
        {
            Console.WriteLine($"Human: {h.GetName()} with ID: {h.GetId()} generates annual cost of: {h.Cost(12)}");
            humanCost += h.Cost(12);
        }

        foreach (var r in allRobots)
        {
            Console.WriteLine($"Robot: {r.GetName()} with ID: {r.GetId()} maintanence cost: {r.AnnualCost()}");
            roboCost += r.AnnualCost();
        }

        foreach (var i in needInternet){
            if(i.GetInternetConnection()) Console.WriteLine($"OOO {i.GetName()} with ID: {i.GetId()} has internet connection");
            else Console.WriteLine($"XXX {i.GetName()} with ID: {i.GetId()} has NO internet connection");
        }

        Console.WriteLine($"Salaries per year: {humanCost}");
        Console.WriteLine($"Maintenance per year: {roboCost}");
    }
}