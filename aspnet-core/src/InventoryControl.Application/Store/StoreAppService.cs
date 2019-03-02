using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using InventoryControl.Store.Dto;
using Microsoft.EntityFrameworkCore;

namespace InventoryControl.Store
{
    public class StoreAppService : AsyncCrudAppService<Store, StoreDto, int, PagedStoreResultRequestDto, CreateStoreDto, StoreDto>, IStoreAppService
    {
        private readonly IRepository<Store> _storeRepository;

        public StoreAppService(IRepository<Store> storeRepository) : base(storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public async Task<ListResultDto<StoreDto>> GetAll()
        {
            var stores = await _storeRepository.GetAll().ToListAsync();
            return new ListResultDto<StoreDto>(ObjectMapper.Map<List<StoreDto>>(stores));
        }
    }
}
