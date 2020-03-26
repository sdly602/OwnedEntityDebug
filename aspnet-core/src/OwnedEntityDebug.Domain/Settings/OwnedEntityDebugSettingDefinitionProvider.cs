using Volo.Abp.Settings;

namespace OwnedEntityDebug.Settings
{
    public class OwnedEntityDebugSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(OwnedEntityDebugSettings.MySetting1));
        }
    }
}
