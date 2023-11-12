namespace BuilderDesignPatternForHouseExample
{
    public class WoodenHouseBuilder : IHouseBuilder
    {
        private readonly House house;
        public WoodenHouseBuilder()
        {
            house = new();
        }
        public void BuildWalls() => house.Walls = "Wooden Walls";
        public void BuildDoors() => house.Doors = "Wooden Doors";
        public void BuildWindows() => house.Windows = "Large Windows";
        public House GetHouse() => house;
    }
}
