using System.Collections.Generic;
using Issue6672.Roles.Dto;

namespace Issue6672.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
