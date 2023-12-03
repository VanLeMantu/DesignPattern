namespace BridgeDesignPattern
{
    public class MySQLImplementation : IDatabaseImplementation
    {
        public void Close()
        {
            Console.WriteLine("MySQLImplementation.Close()");
        }

        public void Connect()
        {
            Console.WriteLine("MySQLImplementation.Connect()");
        }

        public void Execute(string query)
        {
            Console.WriteLine("MySQLImplementation.Execute()");
        }

        public object Fetch()
        {
            Console.WriteLine("MySQLImplementation.Fetch()");
            return null;
        }
    }
}
