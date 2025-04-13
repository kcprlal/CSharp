namespace C3
{
    abstract class Fuel : ITransportable
    {
        protected double volume, weight, density = 0.8;
        public abstract string Type { get; }

        public new string GetType()
        {
            return Type;
        }

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