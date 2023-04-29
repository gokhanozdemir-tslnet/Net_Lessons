namespace Lesson003_Autofac.Models
{
    public class Transient : ITransient
    {
        public string UId { get; set; } = Guid.NewGuid().ToString();
    }
}
