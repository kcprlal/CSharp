namespace C3{
    class OxygenBottle : IVisitPort{
        protected double volume, weight, density = 1;
        public double MaxCapacity { get; set; }=0;
        public OxygenBottle(double maxCapacity){
            MaxCapacity=maxCapacity;
        }
        public double GetMaxCapacity(){ return MaxCapacity; }
        public double VisitPort(){
            double cost = MaxCapacity - volume;
            volume = MaxCapacity;
            return cost*12;
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