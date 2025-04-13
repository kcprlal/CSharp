namespace C3{
    class FoodContainer : IVisitPort{
        protected double volume, weight, density = 35;
        public double MaxCapacity {get; set;} = 0;
        public FoodContainer(double maxCapacity){
            MaxCapacity = maxCapacity;
        }
        public double VisitPort(){
            double cost = MaxCapacity - Volume;
            Volume = MaxCapacity;
            return cost * 38;
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