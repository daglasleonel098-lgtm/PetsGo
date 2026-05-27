using Microsoft.Maui.Media;

namespace PetsGo.Helpers;

public static class ImageHelper
{
    public static async Task<string?> PickImageAsync()
    {
        try
        {
            FileResult? result = await MediaPicker.Default.PickPhotoAsync();

            if (result == null)
                return null;

            return result.FullPath;
        }
        catch
        {
            return null;
        }
    }
}