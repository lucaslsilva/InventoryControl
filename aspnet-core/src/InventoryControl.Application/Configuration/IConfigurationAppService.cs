using System.Threading.Tasks;
using InventoryControl.Configuration.Dto;

namespace InventoryControl.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
