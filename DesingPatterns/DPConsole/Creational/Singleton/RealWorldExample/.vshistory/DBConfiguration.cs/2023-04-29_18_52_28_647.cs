

namespace DPConsole.Creational.Singleton.RealWorldExample
{
    public class DBConfiguration
    {
        private static DBConfiguration _instance;
        private DBConfiguration()
        {
        }

        public static GetDBConfiguration()
        {
            _instance = _instance ?? new DBConfiguration();
            return _instance;
        }
    }
}
