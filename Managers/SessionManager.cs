using PetsGo.Models;

namespace PetsGo.Managers;

public static class SessionManager
{
    public static User CurrentUser { get; private set; }

    public static void SetUser(User user)
    {
        CurrentUser = user;
    }

    public static void Logout()
    {
        CurrentUser = null;
    }
}