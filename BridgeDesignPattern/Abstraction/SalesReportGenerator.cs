namespace BridgeDesignPattern
{
    public class SalesReportGenerator : ReportGenerator
    {
        public SalesReportGenerator(IDatabaseImplementation database) : base(database) { }

        public override void GenerateReport()
        {
            database.Connect();
            database.Close();
        }
    }
}
