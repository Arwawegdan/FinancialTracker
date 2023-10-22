namespace FinancialTracker;

public class Program
{
        public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString)
                                                           .EnableDetailedErrors()
                                                           .EnableSensitiveDataLogging()
                                                           .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

        DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder();
        dbContextOptionsBuilder.UseLazyLoadingProxies();

        WebApplication app = builder.Build();

        if (app.Environment.IsDevelopment())
            app.UseWebAssemblyDebugging();
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseBlazorFrameworkFiles();
        app.UseStaticFiles();

        app.UseRouting();

        app.MapControllers();
        app.MapFallbackToFile("index.html");

        app.Run();
    }
}