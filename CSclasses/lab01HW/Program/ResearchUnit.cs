public class ResearchUnit : MartianBase
{
    protected int m_numberOfWorkers;

    public ResearchUnit(int oxygenLevel,int temperature, int numberOfWorkers) : base(oxygenLevel, temperature)
    {
        m_numberOfWorkers = numberOfWorkers;
    }
}