using System.Threading.Tasks;
using Issue6672.Configuration.Dto;

namespace Issue6672.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
