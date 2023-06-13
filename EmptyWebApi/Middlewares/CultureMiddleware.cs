using System.Globalization;

namespace EmptyWebApi.Middlewares
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate next;

        public CultureMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var cultureQuery = context.Request.Query["culture"];
            if (!string.IsNullOrWhiteSpace(cultureQuery))
            {
                var culture = new CultureInfo(cultureQuery);
                CultureInfo.CurrentCulture = culture;

                Console.WriteLine(DateTime.Now.ToString("dddd MMMM yyyy"));
            }

            await next(context);
        }
    }
}
