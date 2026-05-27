using System.Collections.ObjectModel;
using PetsGo.Models;
using PetsGo.Services;

namespace PetsGo.Managers;

public static class PetManager
{
    public static void AddPet(
        string name,
        string type)
    {
        if (AuthService.CurrentUser == null)
            return;

        if (string.IsNullOrWhiteSpace(name))
            return;

        if (string.IsNullOrWhiteSpace(type))
            return;

        AuthService.CurrentUser.Pets.Add(
            new PetProfile
            {
                Name = name,
                Type = type
            });
    }

    public static ObservableCollection<PetProfile> GetPets()
    {
        if (AuthService.CurrentUser == null)
            return new();

        return AuthService.CurrentUser.Pets;
    }
}