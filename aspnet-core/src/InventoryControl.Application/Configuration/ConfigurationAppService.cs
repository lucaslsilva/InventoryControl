using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using InventoryControl.Configuration.Dto;

namespace InventoryControl.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : InventoryControlAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
