namespace C3{
    class FuelDiesel : Fuel{
        public override string Type => "diesel";
        public FuelDiesel(){
            density = 0.9;
        }
        public string GetDiesel{
            get {return Type;}
        }
    }
}