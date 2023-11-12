namespace BuilderDesignPatternForHouseExample
{
    public class HouseDirector
    {
        public static House Construct(IHouseBuilder houseBuilder)
        {
            houseBuilder.BuildWalls();
            houseBuilder.BuildDoors();
            houseBuilder.BuildWindows();
            return houseBuilder.GetHouse();
        }
    }
}
