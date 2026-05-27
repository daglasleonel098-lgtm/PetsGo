using Microsoft.Maui.ApplicationModel;

namespace PetsGo.Services;

public static class PermissionService
{
    public static async Task<bool> RequestGalleryPermission()
    {
        try
        {
            PermissionStatus status =
                await Permissions.RequestAsync<
                    Permissions.Photos>();

            return status ==
                PermissionStatus.Granted;
        }
        catch
        {
            return false;
        }
    }

    public static async Task<bool> RequestLocationPermission()
    {
        try
        {
            PermissionStatus status =
                await Permissions.RequestAsync<
                    Permissions.LocationWhenInUse>();

            return status ==
                PermissionStatus.Granted;
        }
        catch
        {
            return false;
        }
    }
}