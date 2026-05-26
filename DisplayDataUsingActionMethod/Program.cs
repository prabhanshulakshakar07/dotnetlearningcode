namespace DisplayDataUsingActionMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.MapDefaultControllerRoute(); // Home/Index

            app.Run();
        }
    }
}
