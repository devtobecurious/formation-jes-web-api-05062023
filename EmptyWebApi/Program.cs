using EmptyWebApi;
using EmptyWebApi.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
//var connectionString = builder.Configuration.GetConnectionString("EmptyWebApiContextConnection") ?? throw new InvalidOperationException("Connection string 'EmptyWebApiContextConnection' not found.");

//builder.Services.AddDbContext<EmptyWebApiContext>(options =>
//    options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<EmptyWebApiUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<EmptyWebApiContext>();

// Add services to the container.

var app = builder.Build();

app.UseMiddleware<CultureMiddleware>();

//app.Use((context, next) =>
//{
//    var cultureQuery = context.Request.Query["culture"];
//    if (!string.IsNullOrWhiteSpace(cultureQuery))
//    {
//        var culture = new CultureInfo(cultureQuery);
//        CultureInfo.CurrentCulture = culture;

//        Console.WriteLine(DateTime.Now.ToString("dddd MMMM yyyy"));
//    }

//    return next();
//});



app.MapGet("/", (HttpContext context) =>
{
    return "Ah que johny !";
});
//app.UseAuthentication(); ;

app.MapJediEndpoints();

app.Run();
