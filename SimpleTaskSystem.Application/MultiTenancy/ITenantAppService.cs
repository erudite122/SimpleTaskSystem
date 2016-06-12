using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SimpleTaskSystem.MultiTenancy.Dto;

namespace SimpleTaskSystem.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
