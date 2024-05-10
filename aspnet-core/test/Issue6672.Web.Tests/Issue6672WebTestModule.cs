using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Issue6672.EntityFrameworkCore;
using Issue6672.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Issue6672.Web.Tests
{
    [DependsOn(
        typeof(Issue6672WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Issue6672WebTestModule : AbpModule
    {
        public Issue6672WebTestModule(Issue6672EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Issue6672WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Issue6672WebMvcModule).Assembly);
        }
    }
}