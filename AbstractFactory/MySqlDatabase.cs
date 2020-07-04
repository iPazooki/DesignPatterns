namespace AbstractFactory
{
    /// <summary>
    /// The concrete factory
    /// </summary>
    public class MySqlDatabase : IDatabaseFactory
    {
        public IDatabase CreateDatabaseProvider() => new MySql();
    }

    // The product class
    public class MySql : IDatabase
    {
        public string GetConnectionString() => "My SQL!";
    }
}