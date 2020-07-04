namespace AbstractFactory
{
    /// <summary>
    /// The concrete factory class
    /// </summary>
    public class SqlDatabase : IDatabaseFactory
    {
        public IDatabase CreateDatabaseProvider() => new Sql();
    }

    /// <summary>
    /// The product class
    /// </summary>
    public class Sql : IDatabase
    {
        public string GetConnectionString() => "SQL Server!";
    }
}