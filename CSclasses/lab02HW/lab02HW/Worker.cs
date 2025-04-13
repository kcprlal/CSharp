public abstract class Worker
{
    private string m_name;
    private int m_id;

    public Worker(string name, int id)
    {
        m_name = name;
        m_id = id;
    }

    public string GetName() { return m_name; }
    public int GetId() { return m_id; }
}