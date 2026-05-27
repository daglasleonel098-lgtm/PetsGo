using PetsGo.Models;
using PetsGo.Services;

namespace PetsGo.Managers;

public static class ProfileManager
{
    public static void UpdateDescription(string description)
    {
        if (AuthService.CurrentUser == null)
            return;

        AuthService.CurrentUser.Description = description;
    }

    public static void UpdateWorkSchedule(string schedule)
    {
        if (AuthService.CurrentUser == null)
            return;

        AuthService.CurrentUser.WorkSchedule = schedule;
    }

    public static void UpdateName(string name)
    {
        if (AuthService.CurrentUser == null)
            return;

        if (string.IsNullOrWhiteSpace(name))
            return;

        AuthService.CurrentUser.Name = name;
    }
}