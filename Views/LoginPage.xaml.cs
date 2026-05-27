using PetsGo.Helpers;
using PetsGo.Services;
using PetsGo.Views.Admin;
using PetsGo.Views.Client;
using PetsGo.Views.Walker;

namespace PetsGo.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnRutChanged(
        object sender,
        TextChangedEventArgs e)
    {
        RutEntry.Text =
            RutHelper.FormatRut(
                e.NewTextValue);
    }

    private async void OnLoginClicked(
        object sender,
        EventArgs e)
    {
        string rut =
            RutEntry.Text ?? "";

        string password =
            PasswordEntry.Text ?? "";

        bool success =
            AuthService.Login(
                rut,
                password);

        if (!success)
        {
            await DisplayAlert(
                "Error",
                "Credenciales incorrectas",
                "OK");

            return;
        }

        var user =
            AuthService.CurrentUser;

        if (user == null)
            return;

        if (user.Role == "Client")
        {
            Application.Current.MainPage =
                new ClientMainPage();
        }
        else if (user.Role == "Walker")
        {
            Application.Current.MainPage =
                new WalkerMainPage();
        }
        else
        {
            Application.Current.MainPage =
                new AdminMainPage();
        }
    }

    private async void OnRegisterClicked(
        object sender,
        EventArgs e)
    {
        await Navigation.PushAsync(
            new RegisterPage());
    }

    private async void OnRegisterTapped(
        object sender,
        TappedEventArgs e)
    {
        await Navigation.PushAsync(
            new RegisterPage());
    }
}