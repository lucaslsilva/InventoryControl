using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace InventoryControl.Inventory.Dto
{
    [AutoMapFrom(typeof(Inventory))]
    public class UpdateInventoryDto : EntityDto
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Quantity: {Quantity}";
        }
    }
}
