

namespace DPConsole.Creational.Singleton.RealWorldExample
{
    public class DBConfiguration
    {
        private static DBConfiguration _instance;
        public DBConnection ConnectionString { get; set; }
        private DBConfiguration()
        {
            ConnectionString = new DBConnection { ConnectionString = System.DateTime.Now.ToString() };
        }

        public static DBConfiguration GetDBConfiguration()
        {
            _instance = _instance ?? new DBConfiguration();
            return _instance;
        }
    }
}
