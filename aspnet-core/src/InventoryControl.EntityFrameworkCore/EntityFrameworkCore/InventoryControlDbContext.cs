using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using InventoryControl.Authorization.Roles;
using InventoryControl.Authorization.Users;
using InventoryControl.MultiTenancy;

namespace InventoryControl.EntityFrameworkCore
{
    public class InventoryControlDbContext : AbpZeroDbContext<Tenant, Role, User, InventoryControlDbContext>
    {
        public DbSet<Product.Product> Products { get; set; }
        public DbSet<Store.Store> Stores { get; set; }
        public DbSet<Inventory.Inventory> Inventories { get; set; }
        
        public InventoryControlDbContext(DbContextOptions<InventoryControlDbContext> options)
            : base(options)
        {
        }
    }
}
