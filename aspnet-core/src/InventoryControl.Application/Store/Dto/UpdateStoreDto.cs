using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using InventoryControl.Util;

namespace InventoryControl.Store.Dto
{
    [AutoMapFrom(typeof(Store))]
    public class UpdateStoreDto : EntityDto
    {
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

        public override string ToString()
        {
            return $"Address: {Address}, City: {City}, State: {State}, ZipCode: {ZipCode}, PhoneNumber: {PhoneNumber}";
        }
    }
}
