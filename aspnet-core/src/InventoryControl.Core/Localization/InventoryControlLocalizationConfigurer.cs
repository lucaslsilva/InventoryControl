using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace InventoryControl.Localization
{
    public static class InventoryControlLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(InventoryControlConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(InventoryControlLocalizationConfigurer).GetAssembly(),
                        "InventoryControl.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
