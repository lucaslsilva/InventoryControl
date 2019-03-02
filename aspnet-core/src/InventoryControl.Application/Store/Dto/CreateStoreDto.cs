using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using InventoryControl.Util;

namespace InventoryControl.Store.Dto
{
    [AutoMapFrom(typeof(Store))]
    public class CreateStoreDto : EntityDto
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
