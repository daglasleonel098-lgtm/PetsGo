using PetsGo.Models;
using PetsGo.Services;

namespace PetsGo.Managers;

public static class UserManager
{
    public static List<User> GetAllUsers()
    {
        return DataService.GetUsers();
    }
}