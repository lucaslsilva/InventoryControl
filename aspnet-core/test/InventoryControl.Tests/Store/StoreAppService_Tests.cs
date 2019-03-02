using System.Threading.Tasks;
using InventoryControl.Store;
using Shouldly;
using Xunit;

namespace InventoryControl.Tests.Store
{
    public class StoreAppService_Tests : InventoryControlTestBase
    {
        private readonly IStoreAppService _storeAppService;

        public StoreAppService_Tests()
        {
            _storeAppService = Resolve<IStoreAppService>();
        }

        [Fact]
        public async Task Should_Get_All_Stores()
        {
            var output = await _storeAppService.GetAll();
            output.Items.Count.ShouldBe(1);
        }
    }
}
