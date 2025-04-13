namespace C3
{
    abstract class Human : ITransportable
    {
        protected double volume, weight, density = 2.3;

        public virtual double Volume
        {
            get { return volume; }

            set
            {
                volume = value;
                weight = value * density;
            }
        }

        public virtual double Weight
        {
            get { return weight; }

            set
            {
                weight = value;
                volume = value / density;
            }
        }
    }
}