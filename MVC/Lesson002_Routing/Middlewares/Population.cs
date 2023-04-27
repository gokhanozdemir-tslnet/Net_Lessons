namespace Lesson002_Routing.Middlewares
{
    public class Population
    {

        RequestDelegate? next;

        public Population()
        {
        }

        public Population(RequestDelegate nextDelgate)
        {
                next = nextDelgate;
        }


        //public async Task Invoke(HttpContext context)
        public static async Task EndPoint(HttpContext context)
        {
            //string[] parts = context.Request.Path.ToString().Split('/',StringSplitOptions.RemoveEmptyEntries);
            //if (parts.Length==2 && parts[0] =="population")
            //{
            //string city=parts[1];
            string? city = context.Request.RouteValues["city"] as string;
                int? pop = null; 
                switch ((city??"").ToLower())
                {
                    case "london":
                        pop = 8_136_000;
                        break;
                    case "paris":
                        pop = 2_141_000;
                        break ;
                    case "monaco":
                        pop = 39_000;
                        break;
                }
            if (pop.HasValue) { await context.Response.WriteAsync($"City: {city}, Population: {pop}"); }
            else
            {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
            }
            //if (pop.HasValue)
            //{
            //    //await context.Response
            //    //    .WriteAsync($"City:{city}, Population: {pop}");
            //    //return;
            //}


            //}
            //if (next != null)
            //{
            //    await next(context);
            //}
        }
    }
}
