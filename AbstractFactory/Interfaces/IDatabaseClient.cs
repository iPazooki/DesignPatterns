namespace AbstractFactory
{
    /// <summary>
    /// The client interface
    /// </summary>
    public interface IDatabaseClient
    {
        IDatabase GetDatabase();
    }
}
