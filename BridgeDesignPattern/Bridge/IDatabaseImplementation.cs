namespace BridgeDesignPattern
{
    public interface IDatabaseImplementation
    {
        void Connect();
        void Execute(string query);
        object Fetch();
        void Close();
    }
}
