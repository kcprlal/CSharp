public class PhysicalWorker : Human
{
    public PhysicalWorker(string name, int id) : base(name, id) { }
    public override int Cost(int months) { return months * 4728; }

}