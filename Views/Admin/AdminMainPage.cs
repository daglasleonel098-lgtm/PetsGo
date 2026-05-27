using PetsGo.Views.Shared;

namespace PetsGo.Views.Admin;

public class AdminMainPage : TabbedPage
{
    public AdminMainPage()
    {
        BarBackgroundColor = Color.FromArgb("#1E1E1E");
        BarTextColor = Colors.White;

        Children.Add(
            new NavigationPage(
                new AdminHomePage())
            {
                Title = "Inicio"
            });

        Children.Add(
            new NavigationPage(
                new AdminUsersPage())
            {
                Title = "Usuarios"
            });

        Children.Add(
            new NavigationPage(
                new SettingsPage())
            {
                Title = "Config"
            });
    }
}