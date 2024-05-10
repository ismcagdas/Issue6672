using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Issue6672.MultiTenancy;

namespace Issue6672.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
