using PetsGo.Models;
using PetsGo.Services;

namespace PetsGo.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text?.Trim() ?? "";
        string rut = RutEntry.Text?.Trim() ?? "";
        string phone = PhoneEntry.Text?.Trim() ?? "";
        string email = EmailEntry.Text?.Trim() ?? "";
        string password = PasswordEntry.Text?.Trim() ?? "";
        string role = RolePicker.SelectedItem?.ToString() ?? "";

        if (
            string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(rut) ||
            string.IsNullOrWhiteSpace(phone) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(role)
        )
        {
            await DisplayAlert("Error", "Completa todos los campos", "OK");
            return;
        }

        User user = new()
        {
            Name = name,
            Rut = rut,
            Phone = phone,
            Email = email,
            Password = password,
            Role = role
        };

        bool success = AuthService.Register(user);

        if (!success)
        {
            await DisplayAlert("Error", "El usuario ya existe", "OK");
            return;
        }

        await DisplayAlert("Éxito", "Usuario registrado", "OK");

        await Navigation.PopAsync();
    }
}