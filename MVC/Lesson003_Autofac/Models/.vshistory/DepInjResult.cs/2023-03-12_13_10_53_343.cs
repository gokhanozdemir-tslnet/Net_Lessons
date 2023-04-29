using Lesson018_Autofac.Models;

namespace Lesson018_Autofac.Models
{
    public class DepInjResult
    {
        public DepInjResult()
        {
        }

        public ISingleton Singleton1 { get; set; }
        public ISingleton Singleton2 { get; set; }
        public ISingleton Singleton3 { get; set; }
        public ITransient Transient1 { get; set; }
        public ITransient Transient2 { get; set; }
        public ITransient Transient3 { get; set; }
        public IScope Scope1 { get; set; }
        public IScope Scope2 { get; set; }
        public IScope Scope3 { get; set; }
    }
}