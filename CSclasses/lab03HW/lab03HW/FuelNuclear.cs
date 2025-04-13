namespace C3{
    class FuelNuclear : Fuel{
        public override string Type => "nuclear";
        public FuelNuclear (){
            density = 0.8;
        }

        public string GetNuclear{
            get {return Type;}
        }
    }
}