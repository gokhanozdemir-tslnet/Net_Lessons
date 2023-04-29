
namespace DPConsole.Creational.Singleton
{
    public class Singleton
    {

        private Singleton _instance;
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {

            }

            return new Singleton();
        }

    }
}
