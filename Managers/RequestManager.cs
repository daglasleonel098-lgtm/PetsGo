using PetsGo.Models;
using PetsGo.Services;

namespace PetsGo.Managers;

public static class RequestManager
{
    private static int _currentId = 1;

    public static void CreateRequest(string clientName)
    {
        WalkRequest request = new WalkRequest
        {
            Id = _currentId++,
            ClientName = clientName,
            Status = "Pending"
        };

        DataService.AddRequest(request);
    }
}