
public class OfficeWorker : Human, IInternetConnection
{
    private bool m_internetConnection;

    public OfficeWorker(string name, int id, bool internetConnection) : base(name, id)
    {
        m_internetConnection = internetConnection;
    }
    public override int Cost(int months) { return months * 3490; }
    public bool GetInternetConnection() { return m_internetConnection; }
}