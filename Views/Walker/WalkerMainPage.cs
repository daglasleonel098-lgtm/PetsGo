using PetsGo.Views.Shared;

namespace PetsGo.Views.Walker;

public class WalkerMainPage : TabbedPage
{
    public WalkerMainPage()
    {
        BarBackgroundColor = Color.FromArgb("#1E1E1E");
        BarTextColor = Colors.White;

        Children.Add(
            new NavigationPage(
                new WalkerHomePage())
            {
                Title = "Inicio"
            });

        Children.Add(
            new NavigationPage(
                new WalkerRequestsPage())
            {
                Title = "Solicitudes"
            });

        Children.Add(
            new NavigationPage(
                new ChatPage())
            {
                Title = "Chat"
            });

        Children.Add(
            new NavigationPage(
                new WalkerProfilePage())
            {
                Title = "Perfil"
            });

        Children.Add(
            new NavigationPage(
                new SettingsPage())
            {
                Title = "Config"
            });
    }
}