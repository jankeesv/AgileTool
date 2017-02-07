using Abp.Authorization;
using VelthovenConsultancy.AgileTool.Authorization.Roles;
using VelthovenConsultancy.AgileTool.MultiTenancy;
using VelthovenConsultancy.AgileTool.Users;

namespace VelthovenConsultancy.AgileTool.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
