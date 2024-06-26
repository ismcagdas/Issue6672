﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Issue6672.Configuration;
using Issue6672.Web;

namespace Issue6672.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Issue6672DbContextFactory : IDesignTimeDbContextFactory<Issue6672DbContext>
    {
        public Issue6672DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Issue6672DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Issue6672DbContextConfigurer.ConfigureDesignTime(builder, configuration.GetConnectionString(Issue6672Consts.ConnectionStringName));

            return new Issue6672DbContext(builder.Options);
        }
    }
}
