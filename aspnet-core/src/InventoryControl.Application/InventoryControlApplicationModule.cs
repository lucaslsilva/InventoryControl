using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InventoryControl.Authorization;

namespace InventoryControl
{
    [DependsOn(
        typeof(InventoryControlCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class InventoryControlApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<InventoryControlAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(InventoryControlApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
