namespace BridgeDesignPattern
{
    public abstract class ReportGenerator
    {
        protected IDatabaseImplementation database;

        public ReportGenerator(IDatabaseImplementation database)
        {
            this.database = database;
        }

        public abstract void GenerateReport();
    }
}
