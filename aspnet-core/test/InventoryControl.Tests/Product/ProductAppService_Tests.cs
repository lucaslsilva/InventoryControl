using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InventoryControl.Product;
using Shouldly;
using Xunit;

namespace InventoryControl.Tests.Product
{
    public class ProductAppService_Tests : InventoryControlTestBase
    {
        private readonly IProductAppService _productAppService;

        public ProductAppService_Tests()
        {
            _productAppService = Resolve<IProductAppService>();
        }

        [Fact]
        public async Task Should_Get_All_Products()
        {
            var output = await _productAppService.GetAll();
            output.Items.Count.ShouldBe(2);
        }
    }
}
