using System.Data.Common;
using Abp.Dependency;
using EFCoreSecondLevelCacheInterceptor;
using Microsoft.EntityFrameworkCore;

namespace Issue6672.EntityFrameworkCore
{
    public static class Issue6672DbContextConfigurer
    {
        public static void ConfigureDesignTime(DbContextOptionsBuilder<Issue6672DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
        
        public static void Configure(DbContextOptionsBuilder<Issue6672DbContext> builder, string connectionString)
        {
            var interceptor = IocManager.Instance.Resolve<SecondLevelCacheInterceptor>();
            builder.UseSqlServer(connectionString)
                .AddInterceptors(interceptor);
        }

        public static void Configure(DbContextOptionsBuilder<Issue6672DbContext> builder, DbConnection connection)
        {
            var interceptor = IocManager.Instance.Resolve<SecondLevelCacheInterceptor>();
            builder.UseSqlServer(connection)
                .AddInterceptors(interceptor);
        }
    }
}
