namespace AbstractFactory
{
    /// <summary>
    /// The client class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DatabaseClient<T> : IDatabaseClient where T : IDatabaseFactory, new()
    {
        private readonly T factory;

        public DatabaseClient()
        {
            factory = new T();
        }

        public IDatabase GetDatabase() => factory.CreateDatabaseProvider();
    }
}