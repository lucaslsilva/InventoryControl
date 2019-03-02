using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace InventoryControl.Store.Dto
{
    [AutoMapFrom(typeof(Store))]
    public class StoreDto : EntityDto
    {
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public string City { get; set; }

        public string State { get; set; }
        
        public string ZipCode { get; set; }
        
        public string PhoneNumber { get; set; }
    }
}
