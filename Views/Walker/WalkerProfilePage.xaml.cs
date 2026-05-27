using Microsoft.Maui.Devices.Sensors;
using PetsGo.Managers;
using PetsGo.Services;
using PetsGo.Views.Client;

namespace PetsGo.Views.Walker;

public partial class WalkerProfilePage : ContentPage
{
    public WalkerProfilePage()
    {
        InitializeComponent();

        LoadProfile();
    }

    private void LoadProfile()
    {
        var user =
            AuthService.CurrentUser;

        if (user == null)
            return;

        NameEntry.Text =
            user.Name;

        DescriptionEditor.Text =
            user.Description;

        ScheduleEditor.Text =
            user.WorkSchedule;

        if (!string.IsNullOrWhiteSpace(
            user.ProfileImage))
        {
            ProfileImage.Source =
                user.ProfileImage;
        }
    }

    private async void OnChangePhoto(
        object sender,
        EventArgs e)
    {
        string image =
            await ImageManager
                .PickImage();

        if (string.IsNullOrWhiteSpace(
            image))
            return;

        ProfileImage.Source =
            image;

        if (AuthService.CurrentUser != null)
        {
            AuthService.CurrentUser
                .ProfileImage = image;
        }
    }

    private void OnDeletePhoto(
        object sender,
        EventArgs e)
    {
        ProfileImage.Source = null;

        if (AuthService.CurrentUser != null)
        {
            AuthService.CurrentUser
                .ProfileImage = "";
        }
    }

    private async void OnUpdateLocation(
        object sender,
        EventArgs e)
    {
        try
        {
            var location =
                await Geolocation
                    .GetLastKnownLocationAsync();

            if (location is null)
            {
                location =
                    await Geolocation
                        .GetLocationAsync();
            }

            if (location is null)
            {
                await DisplayAlert(
                    "Error",
                    "No se pudo obtener ubicación",
                    "OK");

                return;
            }

            if (AuthService.CurrentUser != null)
            {
                AuthService.CurrentUser
                    .Latitude =
                        location.Latitude;

                AuthService.CurrentUser
                    .Longitude =
                        location.Longitude;
            }

            await DisplayAlert(
                "Éxito",
                "Ubicación actualizada",
                "OK");
        }
        catch
        {
            await DisplayAlert(
                "Error",
                "Permiso de ubicación denegado",
                "OK");
        }
    }

    private async void OnSwitchRole(
        object sender,
        EventArgs e)
    {
        if (AuthService.CurrentUser == null)
            return;

        AuthService.CurrentUser.Role =
            "Client";

        Application.Current.MainPage =
            new ClientMainPage();

        await Task.CompletedTask;
    }

    private async void OnSaveProfile(
        object sender,
        EventArgs e)
    {
        if (AuthService.CurrentUser == null)
            return;

        AuthService.CurrentUser.Name =
            NameEntry.Text ?? "";

        AuthService.CurrentUser.Description =
            DescriptionEditor.Text ?? "";

        AuthService.CurrentUser.WorkSchedule =
            ScheduleEditor.Text ?? "";

        await DisplayAlert(
            "Guardado",
            "Perfil actualizado",
            "OK");
    }
}