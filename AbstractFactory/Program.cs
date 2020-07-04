using System;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory Design Pattern");

            IDatabaseClient sql = new DatabaseClient<SqlDatabase>();

            ShowResult(sql);

            IDatabaseClient mySql = new DatabaseClient<MySqlDatabase>();

            ShowResult(mySql);

            Console.ReadKey();
        }

        private static void ShowResult(IDatabaseClient sql)
        {
            Console
                .WriteLine($"This connection string is for {sql.GetDatabase().GetConnectionString()}");
        }
    }
}