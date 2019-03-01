using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace InventoryControl.EntityFrameworkCore
{
    public static class InventoryControlDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<InventoryControlDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<InventoryControlDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
