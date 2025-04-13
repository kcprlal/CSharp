namespace C3{
    class Scientist : Human{
        private Equipment equipment;
        public Scientist(Equipment equipment){
            this.equipment = equipment;
        }
        public void Work(double time){
            if(time == 24){
                equipment.GatherData();
            }
        }
    }
}