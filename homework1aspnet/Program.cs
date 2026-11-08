namespace homework1aspnet
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /*Завдання 1 У файлі Program.cs додайте рядок: 
             * app.MapGet("/hello/{name}", (string name) => $"Hello, {name}!"); 
             * Перезапустіть додаток (dotnet run). 
             * Відкрийте https://localhost:7XXX/hello/Alex і переконайтеся
             * , що відображається Hello, Alex! Змініть ім'я в адресі та 
             * перевірте, що відповідь змінюється. 
             * Завдання 2 У файлі Program.cs додайте рядок: app.MapGet("/api/status", () => new { message = "MyHomeWeb is running", time = DateTime.Now }); 
             * Перезапустіть застосунок. Відкрийте http://localhost:7XXX/api/status. Переконайтеся, що у відповіді відображається JSON з полями message і time.*/
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/hello/{name}", (string name) => $"Hello, {name}!");
            app.MapGet("/api/status", () => new { message = "MyHomeWeb is running", time = DateTime.Now });
            app.Run();
        }
    }
}
