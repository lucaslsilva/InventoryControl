using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace InventoryControl.Inventory
{
    [Table("DbInventory")]
    public class Inventory : Entity
    {
        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product.Product Product { get; set; }

        [Required]
        public int StoreId { get; set; }

        [ForeignKey("StoreId")]
        public Store.Store Store { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
