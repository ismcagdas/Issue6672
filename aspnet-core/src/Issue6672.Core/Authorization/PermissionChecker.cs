using Abp.Authorization;
using Issue6672.Authorization.Roles;
using Issue6672.Authorization.Users;

namespace Issue6672.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
