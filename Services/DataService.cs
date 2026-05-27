using PetsGo.Models;

namespace PetsGo.Services;

public static class DataService
{
    public static List<User> Users { get; set; } = new();

    public static List<WalkRequest> Requests { get; set; } = new();

    static DataService()
    {
        Users.Add(new User
        {
            Name = "Administrador",
            Rut = "99999999-9",
            Phone = "999999999",
            Email = "admin@petsgo.cl",
            Password = "admin",
            Role = "Admin"
        });

        Users.Add(new User
        {
            Name = "Paseador",
            Rut = "11111111-1",
            Phone = "111111111",
            Email = "walker@petsgo.cl",
            Password = "1234",
            Role = "Walker"
        });

        Users.Add(new User
        {
            Name = "Cliente",
            Rut = "22222222-2",
            Phone = "222222222",
            Email = "client@petsgo.cl",
            Password = "1234",
            Role = "Client"
        });
    }

    public static void AddRequest(WalkRequest request)
    {
        if (request == null)
            return;

        Requests.Add(request);
    }

    public static List<WalkRequest> GetRequests()
    {
        return Requests;
    }

    public static List<User> GetUsers()
    {
        return Users;
    }
}