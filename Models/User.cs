using System.Collections.ObjectModel;

namespace PetsGo.Models;

public class User
{
    public string Name { get; set; } = "";

    public string Rut { get; set; } = "";

    public string Phone { get; set; } = "";

    public string Email { get; set; } = "";

    public string Password { get; set; } = "";

    public string Role { get; set; } = "";

    public string Description { get; set; } = "";

    public string WorkSchedule { get; set; } = "";

    public string ProfileImage { get; set; } = "";

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public ObservableCollection<PetProfile> Pets
    { get; set; } =
            new();
}