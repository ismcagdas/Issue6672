using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Issue6672.Configuration;

namespace Issue6672.Web.Host.Startup
{
    [DependsOn(
       typeof(Issue6672WebCoreModule))]
    public class Issue6672WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Issue6672WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Issue6672WebHostModule).GetAssembly());
        }
    }
}
