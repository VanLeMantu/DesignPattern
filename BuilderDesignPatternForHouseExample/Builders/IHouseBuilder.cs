namespace BuilderDesignPatternForHouseExample
{
    public interface IHouseBuilder
    {
        void BuildWalls();
        void BuildDoors();
        void BuildWindows();
        House GetHouse();
    }
}
