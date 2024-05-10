using System.Collections.Generic;
using Issue6672.Roles.Dto;

namespace Issue6672.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
