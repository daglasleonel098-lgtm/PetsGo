using PetsGo.Models;

namespace PetsGo.Managers;

public static class LocationManager
{
    public static UserLocation CurrentLocation =
        new UserLocation
        {
            City = "Chimbarongo",
            Region = "O'Higgins",
            Latitude = -34.7121,
            Longitude = -71.0434
        };

    public static UserLocation GetCurrentLocation()
    {
        return CurrentLocation;
    }
}