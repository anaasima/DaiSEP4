using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaiSEP4.DataAccess;
using DatabaseSEP4.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DaiSEP4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            using (SEP4DBContext context = new SEP4DBContext())
            {
                List<DimGarden> gardens = context.DimGarden.ToList();
                Console.WriteLine("Gardens" + gardens);
                // context.DimGarden.Add(new DimGarden
                // {
                //     City = "Horsens",
                //     LandArea = 12.5,
                //     Name = "Me",
                //     Number = 23,
                //     Street = "Main"
                // });
                // context.SaveChangesAsync();
            }
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}