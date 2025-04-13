public abstract class Robot : Worker
{
    protected string m_type;
    public Robot(string name, int id, string type) : base(name, id)
    {
        m_type = type;
    }
    public abstract int AnnualCost();
}