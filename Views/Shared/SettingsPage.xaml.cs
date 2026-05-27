using PetsGo.Views;

namespace PetsGo.Views.Shared;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    private void OnLogoutClicked(
        object sender,
        EventArgs e)
    {
        Application.Current.MainPage =
            new NavigationPage(
                new LoginPage());
    }
}