using PetsGo.Models;

namespace PetsGo.Services;

public static class AuthService
{
    public static User? CurrentUser { get; set; }

    public static bool Login(string rut, string password)
    {
        var user = DataService.Users.FirstOrDefault(u =>
            u.Rut == rut &&
            u.Password == password);

        if (user == null)
            return false;

        CurrentUser = user;
        return true;
    }

    public static bool Register(User user)
    {
        if (user == null)
            return false;

        bool exists = DataService.Users.Any(u => u.Rut == user.Rut);

        if (exists)
            return false;

        DataService.Users.Add(user);

        return true;
    }

    public static void Logout()
    {
        CurrentUser = null;
    }
}