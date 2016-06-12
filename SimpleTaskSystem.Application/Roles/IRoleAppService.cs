using System.Threading.Tasks;
using Abp.Application.Services;
using SimpleTaskSystem.Roles.Dto;

namespace SimpleTaskSystem.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
