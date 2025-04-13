namespace C3
{
    class FuelTank : IVisitPort
    {
        protected double volume, weight, density = 0.9;
        public double MaxCapacity { get; protected set; } = 0;
        private Fuel fuel;
        public double VisitPort()
        {
            double cost = MaxCapacity - Volume;
            Volume = MaxCapacity;
            if(fuel.Type == "diesel")
            return cost * 7.98;
            else return cost * 15.0;
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

        public double GetMaxCapacity() { return MaxCapacity; }
        public string GetFuelType() { return fuel.Type; }
        public FuelTank(double maxCapacity, Fuel fuel)
        {
            MaxCapacity = maxCapacity;
            this.fuel = fuel;
        }
    }
}