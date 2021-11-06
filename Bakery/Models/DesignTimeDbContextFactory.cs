using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extentions.Configuration;
using System.IO;

namespace Bakery.Models
{
  public class BakeryContextFactory : IDesignTimeDbContextFactory<BakeryContextFactory>
  {

    BakeryContextFactory IDesignTimeDbContextFactory<BakeryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<BakeryContextFactory>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new BakeryContextFactory(builder.Options);
      
    }
  }
}