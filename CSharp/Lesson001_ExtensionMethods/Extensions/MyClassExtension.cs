

namespace Lesson001_ExtensionMethods.Extensions
{
    public static class MyClassExtension
    {

        public static string MyMeyhod(this MyClass myclass, string param)
        {
            return $"Full description {myclass.Id} {myclass.Name} {myclass.Description} {param}";
        }
    }
}
