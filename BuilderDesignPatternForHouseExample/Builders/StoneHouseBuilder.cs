namespace BuilderDesignPatternForHouseExample
{
    public class StoneHouseBuilder : IHouseBuilder
    {
        private readonly House house;
        public StoneHouseBuilder() => house = new();
        //public StoneHouseBuilder()
        //{
        //    house = new House();
        //}
        public void BuildWalls() 
        { 
            house.Walls = "Stone Walls"; 
        }
        public void BuildDoors() => house.Doors = "Metal Doors";
        public void BuildWindows() => house.Windows = "Small Windows";
        //public House GetHouse() => house;
        public House GetHouse()
        {
            return house;
        }
    }
}
