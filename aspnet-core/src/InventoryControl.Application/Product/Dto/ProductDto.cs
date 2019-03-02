using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace InventoryControl.Product.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto : EntityDto
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public string Brand { get; set; }

        public double Price { get; set; }

        public byte[] Picture { get; set; }
    }
}
