
namespace DPConsole.Creational.Singleton
{
    public class Singleton
    {
        public MyClass MySetting { get; set; }
        private static Singleton? _instance;


        private Singleton()
        {
            MySetting = new MyClass();
        }

        public static Singleton GetInstance()
        {
            _instance = _instance ?? new Singleton();
            return new Singleton();
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
