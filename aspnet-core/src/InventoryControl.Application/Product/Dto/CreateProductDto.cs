using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using InventoryControl.Util;

namespace InventoryControl.Product.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class CreateProductDto : EntityDto
    {
        [Required]
        [StringLength(AnnotationsUtil.MediumString)]
        public string Code { get; set; }

        [StringLength(AnnotationsUtil.LongString)]
        public string Description { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public double Price { get; set; }

        public byte[] Picture { get; set; }
    }
}
