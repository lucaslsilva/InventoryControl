using System.Collections.Generic;
using Abp.Domain.Repositories;

namespace InventoryControl.Product
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetAllByBrand(string brandName);
    }
}
