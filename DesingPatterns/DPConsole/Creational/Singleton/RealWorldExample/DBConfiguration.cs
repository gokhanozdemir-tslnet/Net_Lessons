

namespace DPConsole.Creational.Singleton.RealWorldExample
{
    public class DBConfiguration
    {
        private static DBConfiguration _instance;
        public DBConnection DbConnection { get; set; }
        private DBConfiguration()
        {
            DbConnection = new DBConnection { ConnectionString = System.DateTime.Now.ToString() };
            Thread.Sleep(1000);
        }

        public static DBConfiguration GetDBConfiguration()
        {
            _instance = _instance ?? new DBConfiguration();
            return _instance;
        }
    }
}
