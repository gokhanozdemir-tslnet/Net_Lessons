using Lesson003_DependencyInjection.Utils;

namespace Lesson003_DependencyInjection.Services
{
    public interface ISingletonGuideService
    {
    }


    public class GuideServiceSingleton : ISingletonGuideService
    {
        //public Guid guid = new Guid();
        public string GuidStr { get; set; } = Guid.NewGuid().ToString();
        //public async Task<string> Format()
        //{

        //    return $"Guid Singleton {guid}";
        //}
    }

    public interface IScobeGuideService
    {
    }
    /*
     * 
     * Scoped
In this service, with every HTTP request, we get a new instance.
The same instance is provided for the entire scope of that request.
eg., if we have a couple of parameter in the controller, both object contains the same instance across the request
This is a better option when you want to maintain a state within a request.
     * 
     * 
     */
    public class GuideServiceScobe : IScobeGuideService
    {
        //public Guid guid = new Guid();
        public string GuidStr { get; set; } = Guid.NewGuid().ToString();
        //public async Task<string> Format()
        //{

        //    return $"Guid scobe {guid}";
        //}
    }

    public interface ITransientGuideService
    {
    }
    //    Transient
    //A new service instance is created for each object in the HTTP request.
    //This is a good approach for the multithreading approach because both objects are independent of one another.
    //The instance is created every time they will use more memory and resources and can have a negative impact on performance
    //Utilize for the lightweight service with little or no state.

    public class GuideServiceTransient : ITransientGuideService
    {
        //public Guid guid = new Guid();
        public string GuidStr { get; set; } = Guid.NewGuid().ToString();
        //public async Task<string> Format()
        //{

        //    return $"Guid transient {guid}";
        //}
    }

    public class Service
    {
        public GuideServiceSingleton? Singleton { get; set; }
        public GuideServiceScobe? Scobe { get; set; }
        public GuideServiceTransient? Transient { get; set; }

    }



    public interface ITransientService
    {
        Guid GetOperationID();
    }
    public interface IScopedService
    {
        Guid GetOperationID();
    }
    public interface ISingletonService
    {
        Guid GetOperationID();
    }



    public class OperationService : ITransientService,
    IScopedService,
    ISingletonService
    {
        Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}
