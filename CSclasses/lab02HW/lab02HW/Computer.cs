public class Computer : Robot, IInternetConnection
{
    private bool m_internetConnection;
    public Computer(string name, int id, bool internetConnection) : base(name, id, "computer")
    {
        m_internetConnection = internetConnection;
    }

    public override int AnnualCost() { return 500; }

    public bool GetInternetConnection() { return m_internetConnection; }

}