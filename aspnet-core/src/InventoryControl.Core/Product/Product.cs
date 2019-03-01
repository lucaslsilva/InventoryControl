using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using InventoryControl.Util;

namespace InventoryControl.Product
{
    [Table("DbProduct")]
    public class Product : Entity
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
