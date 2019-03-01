using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InventoryControl.Configuration;

namespace InventoryControl.Web.Host.Startup
{
    [DependsOn(
       typeof(InventoryControlWebCoreModule))]
    public class InventoryControlWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public InventoryControlWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InventoryControlWebHostModule).GetAssembly());
        }
    }
}
