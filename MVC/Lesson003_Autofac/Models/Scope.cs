namespace Lesson003_Autofac.Models
{
    public class Scope : IScope
    {
        public string UId { get; set; } = Guid.NewGuid().ToString();
    }
}
