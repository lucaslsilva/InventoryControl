using Abp.Application.Services;
using Abp.Domain.Repositories;
using InventoryControl.Inventory.Dto;

namespace InventoryControl.Inventory
{
    public class InventoryAppService : ApplicationService, IInventoryAppService
    {
        private readonly IRepository<Inventory> _inventoryRepository;

        public InventoryAppService(IRepository<Inventory> repository)
        {
            _inventoryRepository = repository;
        }

        public void UpdateInventory(UpdateInventoryDto input)
        {
            Logger.Info("Updating an inventory for input: " + input);

            var inventory = _inventoryRepository.Get(input.Id);

            inventory.Quantity = input.Quantity;
        }

        public void CreateInventory(CreateInventoryDto input)
        {
            Logger.Info("Creating an inventory for input: " + input);

            var inventory = new Inventory
            {
                ProductId = input.ProductId,
                StoreId = input.StoreId,
                Quantity = input.Quantity
            };

            _inventoryRepository.Insert(inventory);
        }
    }
}
