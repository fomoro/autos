
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using vehicles.api.Data;

namespace vehicles.api
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            IWebHost host = CreateWebHostBuilder(args).Build();
            RunSeeding(host);
            host.Run();
        }

        //cada que corra el proyecto verifique y cree la base de datos
        private static void RunSeeding(IWebHost host)
        {            
            IServiceScopeFactory scopeFactory = host.Services.GetService<IServiceScopeFactory>();
            using (IServiceScope scope = scopeFactory.CreateScope())
            {
                SeedDb seeder = scope.ServiceProvider.GetService<SeedDb>();
                seeder.SeedAsync().Wait();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
        }
    }
}
