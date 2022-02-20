using FreeCourseServices.Catalog.DTOs;
using FreeCourseServices.Catalog.Services.CategoryService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace FreeCourseServicesCatalog
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var  host= CreateHostBuilder(args).Build();
            using (var scope=host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                var categoryService = serviceProvider.GetRequiredService<ICategoryService>();

                if (!categoryService.GetAllAsync().Result.Data.Any())
                {
                    categoryService.CreateAsync(new CategoryDto { Name = "Rails" }).Wait();
                    categoryService.CreateAsync(new CategoryDto { Name = "Ruby" }).Wait();
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
