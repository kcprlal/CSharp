public class UsableArea : MartianBase
{
    protected int m_size;

    public UsableArea(int oxygenLevel, int temperature, int size) : base(oxygenLevel, temperature)
    {
        m_size = size;
    }
}