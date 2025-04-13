public class MechanicalRobot : Robot
{
    public MechanicalRobot(string name, int id) : base(name, id, "mechanical") { }

    public override int AnnualCost() { return 2000; }
}