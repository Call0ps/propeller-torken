using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using PropellerTorkenMain.Services;
using PropellerTorkenMain.Models.Database;

namespace PropellerTorkenMain
{
    public class Program
    {
        public OrderService orderService = new OrderService();

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            CreateDbIfNotThere();
        }

        private static void CreateDbIfNotThere()
        {
            using (var context = new Models.Database.PropellerDataContext())
            {
                context.Database.EnsureCreated();
                context.SaveChanges();
            }
        }
    }
}