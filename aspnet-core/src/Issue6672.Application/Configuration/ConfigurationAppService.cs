using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Issue6672.Configuration.Dto;

namespace Issue6672.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Issue6672AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
