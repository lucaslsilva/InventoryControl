using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using InventoryControl.Authorization.Roles;
using InventoryControl.Authorization.Users;
using InventoryControl.MultiTenancy;

namespace InventoryControl.EntityFrameworkCore
{
    public class InventoryControlDbContext : AbpZeroDbContext<Tenant, Role, User, InventoryControlDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public InventoryControlDbContext(DbContextOptions<InventoryControlDbContext> options)
            : base(options)
        {
        }
    }
}
