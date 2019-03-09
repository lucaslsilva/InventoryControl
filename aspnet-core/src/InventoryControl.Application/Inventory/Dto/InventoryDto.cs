using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace InventoryControl.Inventory.Dto
{
    [AutoMapFrom(typeof(Inventory))]
    public class InventoryDto : EntityDto
    {
        public int ProductId { get; set; }
        
        public Product.Product Product { get; set; }
        
        public int StoreId { get; set; }
        
        public Store.Store Store { get; set; }
        
        public int Quantity { get; set; }
    }
}
