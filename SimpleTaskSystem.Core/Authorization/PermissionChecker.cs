using Abp.Authorization;
using SimpleTaskSystem.Authorization.Roles;
using SimpleTaskSystem.MultiTenancy;
using SimpleTaskSystem.Users;

namespace SimpleTaskSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
