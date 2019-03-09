using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace InventoryControl.Inventory.Dto
{
    [AutoMapFrom(typeof(Inventory))]
    public class CreateInventoryDto : EntityDto
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

        public override string ToString()
        {
            return $"ProductId: {ProductId}, StoreId: {StoreId}, Quantity: {Quantity}";
        }
    }
}
