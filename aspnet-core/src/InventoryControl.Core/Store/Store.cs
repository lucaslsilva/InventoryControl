using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using InventoryControl.Util;

namespace InventoryControl.Store
{
    [Table("DbStore")]
    public class Store : Entity
    {
        [Required]
        [StringLength(AnnotationsUtil.MediumString)]
        public string Name { get; set; }

        [Required]
        [StringLength(AnnotationsUtil.LongString)]
        public string Address { get; set; }

        [StringLength(AnnotationsUtil.ShortString)]
        public string City { get; set; }

        [StringLength(AnnotationsUtil.ShortString)]
        public string State { get; set; }

        [StringLength(AnnotationsUtil.ShortString)]
        public string ZipCode { get; set; }

        [StringLength(AnnotationsUtil.ShortString)]
        public string PhoneNumber { get; set; }
    }
}
