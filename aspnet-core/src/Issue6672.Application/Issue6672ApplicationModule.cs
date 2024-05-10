using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Issue6672.Authorization;

namespace Issue6672
{
    [DependsOn(
        typeof(Issue6672CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Issue6672ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Issue6672AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Issue6672ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
