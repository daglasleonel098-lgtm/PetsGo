namespace PetsGo.Helpers;

public static class AlertHelper
{
    public static async Task Show(string title, string message)
    {
        if (Application.Current?.MainPage != null)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, "OK");
        }
    }
}