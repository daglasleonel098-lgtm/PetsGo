using PetsGo.Services;

namespace PetsGo.Managers;

public static class RoleManager
{
    public static void ToggleRole()
    {
        if (AuthService.CurrentUser == null)
            return;

        if (AuthService.CurrentUser.Role == "Walker")
        {
            AuthService.CurrentUser.Role = "Client";
        }
        else if (AuthService.CurrentUser.Role == "Client")
        {
            AuthService.CurrentUser.Role = "Walker";
        }
    }
}