namespace BuilderDesignPatternForHouseExample
{
    public class WoodenHouseBuilder : IHouseBuilder
    {
        private readonly House house;
        public WoodenHouseBuilder()
        {
            house = new House();
        }
        public void BuildWalls() => house.Walls = "Wooden Walls";
        public void BuildDoors() => house.Doors = "Wooden Doors";
        public void BuildWindows() => house.Windows = "Wooden Windows";
        public House GetHouse() => house;
    }
}
