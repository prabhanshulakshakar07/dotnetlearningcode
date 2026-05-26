namespace EmptyTemplateDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();



            //MIddleware : to configure endpoint/ routing


            #region
            //app.MapGet("/",() => "Get : Hello World" );
            //app.MapPost("/", () =>  "Post : Hello World" );
            //app.MapPut("/", () =>  "Put : Hello World" );
            //app.MapDelete("/", () =>  "Delete : Hello World" );
            #endregion

            app.Use(async (httpcontext, next) =>
            {
                await httpcontext.Response.WriteAsync("Hello prabhanshu1 !!!");
                await httpcontext.Response.WriteAsync("Hello prabhanshu2 !!!");
                next(httpcontext);
                await httpcontext.Response.WriteAsync("Hello prabhanshu3 !!!");

            });

            app.Run(async (httpcontext) =>
            {
                await httpcontext.Response.WriteAsync("Hello prabhanshu 4!!!");
            }); 


            app.Run();
        }
    }
}
