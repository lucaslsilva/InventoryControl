using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.EntityFrameworkCore;
using InventoryControl.Product;

namespace InventoryControl.EntityFrameworkCore.Repositories
{
    public class ProductRepository : InventoryControlRepositoryBase<Product.Product>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<InventoryControlDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public List<Product.Product> GetAllByBrand(string brandName)
        {
            var query = GetAll();

            if (!string.IsNullOrEmpty(brandName))
            {
                query = query.Where(p => p.Brand == brandName);
            }

            return query
                .OrderBy(p => p.Code)
                .ToList();
        }
    }
}
