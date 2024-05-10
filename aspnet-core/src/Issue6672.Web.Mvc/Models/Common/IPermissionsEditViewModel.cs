using System.Collections.Generic;
using Issue6672.Roles.Dto;

namespace Issue6672.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}