namespace Lesson002_Routing.Middlewares
{
    public class Capital
    {
        private RequestDelegate? _next;
        public Capital(RequestDelegate? next)
        {
            _next = next;
        }

        public static async Task EndPoint(HttpContext context)
        {
            string? capital = null;
            string? country = context.Request.RouteValues["country"] as string;

            switch ((country ?? "").ToLower())
            {
                case "uk":
                    capital = "London";
                    break;
                case "france":
                    capital = "Paris";
                    break;
                case "monaco":
                    //context.Response.Redirect($"/population/{country}");
                    LinkGenerator? generator = context.RequestServices.GetService<LinkGenerator>();
                    string? url = generator?.GetPathByRouteValues(context, "population", new { city = country });
                    if (url != null)
                    {
                        context.Response.Redirect(url);
                    }
                    return;
            }
        }

    }
}
