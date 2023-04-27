namespace Lesson002_Routing.Middlewares
{
    public class CustomRouteConstraint : IRouteConstraint
    {
        private static string[] countries = { "uk", "france", "monaco" };
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            string segmentValue = values[routeKey] as string  ?? "";
            return Array.IndexOf(countries, segmentValue.ToLower()) >= -1;
        }
    }
}
