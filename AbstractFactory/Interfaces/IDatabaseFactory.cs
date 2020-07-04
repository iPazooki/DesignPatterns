namespace AbstractFactory
{
    /// <summary>
    /// The abstract Factory interface
    /// </summary>
    public interface IDatabaseFactory
    {
        IDatabase CreateDatabaseProvider();
    }
}