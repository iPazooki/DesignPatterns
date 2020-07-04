using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// Singleton class
    /// </summary>
    public sealed class ConnectionSingleton
    {
        /// <summary>
        /// Static members will be loaded eagerly immediately when class is loaded.
        /// </summary>
        private static readonly ConnectionSingleton instance = new ConnectionSingleton();

        private readonly List<string> connectionStrings;

        private ConnectionSingleton()
        {
            connectionStrings = new List<string>() {
                "My SQL connection string",
                "SQL connection string"
                };
        }

        public static ConnectionSingleton GetInstance()
        {
            return instance;
        }

        public List<string> GetConnectionStrings()
        {
            return connectionStrings;
        }
    }
}