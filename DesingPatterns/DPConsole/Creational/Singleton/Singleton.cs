
namespace DPConsole.Creational.Singleton
{
    public class Singleton
    {
        public Guid GuidId { get; set; }
        public MyClass MySetting { get; set; }
        private static Singleton? _instance;


        private Singleton()
        {
            GuidId = Guid.NewGuid();
            MySetting = new MyClass();
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

    }

    public class MyClass
    {
        public Guid MyClassPropId { get; private set; }
        public MyClass()
        {
            MyClassPropId = Guid.NewGuid();
        }
    }
}
