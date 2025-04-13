namespace C3{
    class Engine{
        private FuelTank tank;
        private Waste waste;
        public Engine(FuelTank tank, Waste waste){
            this.waste = waste;
            this.tank = tank;
        }
        public double GetVelocity(double submarineWeight){
            return Math.Clamp(100-(submarineWeight/1000), 0, 100);
        }
        public bool CheckFuelBeforeTravel(double travelTime){
            return tank.Volume > travelTime;
        }
        public void Travel(double travelTime){
            tank.Volume -= travelTime*10.0;
            waste.Volume += travelTime * 15.0;
        }
    }
}