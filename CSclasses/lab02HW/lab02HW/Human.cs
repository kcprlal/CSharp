public abstract class Human : Worker
{
    public Human(string name, int id) : base(name, id) { }
    public abstract int Cost(int months);
}