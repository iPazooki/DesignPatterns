namespace AbstractFactory
{
    /// <summary>
    /// The abstract product interface
    /// </summary>
    public interface IDatabase
    {
        string GetConnectionString();
    }
}