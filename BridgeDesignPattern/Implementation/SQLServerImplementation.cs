namespace BridgeDesignPattern
{
    public class SQLServerImplementation : IDatabaseImplementation
    {
        public void Close()
        {
            Console.WriteLine("SQLServerImplementation.Close()");
        }

        public void Connect()
        {
            Console.WriteLine("SQLServerImplementation.Connect()");
        }

        public void Execute(string query)
        {
            Console.WriteLine("SQLServerImplementation.Execute()");
        }

        public object Fetch()
        {
            Console.WriteLine("SQLServerImplementation.Fetch()");
            return null;
        }
    }
}
