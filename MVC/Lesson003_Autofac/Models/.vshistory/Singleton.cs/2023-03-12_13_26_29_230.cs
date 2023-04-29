namespace Lesson018_Autofac.Models
{
    public class Singleton : ISingleton
    {
        public string UId { get; set; } = Guid.NewGuid().ToString();
    }
}
