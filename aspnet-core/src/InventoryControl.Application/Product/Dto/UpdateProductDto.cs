using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using InventoryControl.Util;

namespace InventoryControl.Product.Dto
{
    public class UpdateProductDto : EntityDto
    {
        [StringLength(AnnotationsUtil.LongString)]
        public string Description { get; set; }
        
        public string Brand { get; set; }
        
        public double? Price { get; set; }

        public byte[] Picture { get; set; }

        public override string ToString()
        {
            return $"Description: {Description}, Brand: {Brand}, Price: {Price}";
        }
    }
}
