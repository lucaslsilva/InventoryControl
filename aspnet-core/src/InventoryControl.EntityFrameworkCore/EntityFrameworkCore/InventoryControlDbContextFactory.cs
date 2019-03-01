using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using InventoryControl.Configuration;
using InventoryControl.Web;

namespace InventoryControl.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class InventoryControlDbContextFactory : IDesignTimeDbContextFactory<InventoryControlDbContext>
    {
        public InventoryControlDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<InventoryControlDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            InventoryControlDbContextConfigurer.Configure(builder, configuration.GetConnectionString(InventoryControlConsts.ConnectionStringName));

            return new InventoryControlDbContext(builder.Options);
        }
    }
}
