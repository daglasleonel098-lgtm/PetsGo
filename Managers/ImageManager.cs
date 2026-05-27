using Microsoft.Maui.Storage;

namespace PetsGo.Managers;

public static class ImageManager
{
    public static async Task<string>
        PickImage()
    {
        try
        {
            FileResult? photo =
                await MediaPicker
                    .PickPhotoAsync();

            if (photo == null)
                return "";

            return photo.FullPath;
        }
        catch
        {
            return "";
        }
    }
}