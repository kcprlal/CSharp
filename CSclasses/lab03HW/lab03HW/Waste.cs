using System.Dynamic;

namespace C3
{
    class Waste : IVisitPort
    {
        protected double weight, volume, density = 23;
        public double VisitPort()
        {
            volume = 0;
            return 500;
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