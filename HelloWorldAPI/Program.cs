namespace HelloWorldAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // GET /api/hello
            app.MapGet("/api/hello", () =>
            {
                return new
                {
                    message = "Hello from a C# API!",
                    serverTime = DateTime.Now
                };
            });

            app.Run();
        }
    }
}
