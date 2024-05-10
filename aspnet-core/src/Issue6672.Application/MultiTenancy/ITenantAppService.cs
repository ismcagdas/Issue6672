using Abp.Application.Services;
using Issue6672.MultiTenancy.Dto;

namespace Issue6672.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

