using Abp.Authorization;
using InventoryControl.Authorization.Roles;
using InventoryControl.Authorization.Users;

namespace InventoryControl.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
