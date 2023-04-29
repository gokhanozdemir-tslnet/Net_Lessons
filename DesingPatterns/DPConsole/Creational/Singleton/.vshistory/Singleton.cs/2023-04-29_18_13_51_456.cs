
namespace DPConsole.Creational.Singleton
{
    public class Singleton
    {

        private static Singleton? _instance;


        private Singleton() { }

        public static Singleton GetInstance()
        {
            _instance = _instance ?? new Singleton();
            return new Singleton();
        }

    }

    public class MyClass
    {
        public Guid MyClassPropId { get; set; }
    }
}
