namespace MVCEmptyDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //di container configuration
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            //middleware configuration
            //default  URL  : "/Home/Index"

            //app.MapDefaultControllerRoute();


            // Conventional based routing
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.MapControllerRoute(
                name: "fispl",
                pattern: "{controller=Demo}/{action=Data}/{unm}"


                );








            //host , load ,start
            app.Run();
        }
    }
}
