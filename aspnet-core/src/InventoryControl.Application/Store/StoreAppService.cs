using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using InventoryControl.Store.Dto;
using Microsoft.EntityFrameworkCore;

namespace InventoryControl.Store
{
    public class StoreAppService : ApplicationService, IStoreAppService
    {
        private readonly IRepository<Store> _storeRepository;

        public StoreAppService(IRepository<Store> storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public async Task<ListResultDto<StoreDto>> GetAll()
        {
            var stores = await _storeRepository.GetAll().ToListAsync();
            return new ListResultDto<StoreDto>(ObjectMapper.Map<List<StoreDto>>(stores));
        }

        public void UpdateStore(UpdateStoreDto input)
        {
            Logger.Info("Updating a store for input: " + input);

            var store = _storeRepository.Get(input.Id);

            if (!string.IsNullOrEmpty(input.Address))
            {
                store.Address = input.Address;
            }

            if (!string.IsNullOrEmpty(input.City))
            {
                store.City = input.City;
            }

            if (!string.IsNullOrEmpty(input.State))
            {
                store.State = input.State;
            }

            if (!string.IsNullOrEmpty(input.ZipCode))
            {
                store.ZipCode = input.ZipCode;
            }

            if (!string.IsNullOrEmpty(input.PhoneNumber))
            {
                store.PhoneNumber = input.PhoneNumber;
            }
        }

        public void CreateStore(CreateStoreDto input)
        {
            Logger.Info("Creating a store for input: " + input);

            var store = new Store
            {
                Name = input.Name,
                Address = input.Address,
                City = input.City,
                State = input.State,
                ZipCode = input.ZipCode,
                PhoneNumber = input.PhoneNumber
            };

            _storeRepository.Insert(store);
        }
    }
}
