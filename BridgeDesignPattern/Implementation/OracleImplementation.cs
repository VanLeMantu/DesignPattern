namespace BridgeDesignPattern
{
    public class OracleImplementation : IDatabaseImplementation
    {
        public void Close()
        {
            Console.WriteLine("OracleImplementation.Close()");
        }

        public void Connect()
        {
            Console.WriteLine("OracleImplementation.Connect()");
        }

        public void Execute(string query)
        {
            Console.WriteLine("OracleImplementation.Execute()");
        }

        public object Fetch()
        {
            Console.WriteLine("OracleImplementation.Fetch()");
            return null;
        }
    }
}
