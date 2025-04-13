namespace C3
{
    class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> crew;
        public LifeSupportSystem(List<OxygenBottle> bottles, FoodContainer container, Waste waste, List<Human> crew)
        {
            oxygenBottles = bottles;
            foodContainer = container;
            this.waste = waste;
            this.crew = crew;
        }
        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            return oxygenBottles.Count > 0 && foodContainer.Volume > 0;
        }
        public void Run(double travelTime)
        {
            int i = 0;
            while (i < oxygenBottles.Count)
            {
                if (oxygenBottles[i].Volume > 10.0)
                {
                    oxygenBottles[i].Volume -= 10.0 * crew.Count * travelTime;
                    break;
                }
            }
            foodContainer.Volume -= 15 * crew.Count * travelTime;
            waste.Volume += 10 * crew.Count * travelTime;
        }
    }
}