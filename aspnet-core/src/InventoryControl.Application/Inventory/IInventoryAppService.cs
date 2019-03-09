using Abp.Application.Services;
using InventoryControl.Inventory.Dto;

namespace InventoryControl.Inventory
{
    public interface IInventoryAppService : IApplicationService
    {
        void UpdateInventory(UpdateInventoryDto input);
        void CreateInventory(CreateInventoryDto input);
    }
}
