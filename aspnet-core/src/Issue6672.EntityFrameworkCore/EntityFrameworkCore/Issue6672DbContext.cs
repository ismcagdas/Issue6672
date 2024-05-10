using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Issue6672.Authorization.Roles;
using Issue6672.Authorization.Users;
using Issue6672.MultiTenancy;

namespace Issue6672.EntityFrameworkCore
{
    public class Issue6672DbContext : AbpZeroDbContext<Tenant, Role, User, Issue6672DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Issue6672DbContext(DbContextOptions<Issue6672DbContext> options)
            : base(options)
        {
        }
    }
}
