using PetsGo.Views.Shared;

namespace PetsGo.Views.Client;

public class ClientMainPage : TabbedPage
{
    public ClientMainPage()
    {
        BarBackgroundColor = Color.FromArgb("#1E1E1E");
        BarTextColor = Colors.White;

        Children.Add(
            new NavigationPage(
                new ClientHomePage())
            {
                Title = "Inicio"
            });

        Children.Add(
            new NavigationPage(
                new ClientMapPage())
            {
                Title = "Mapa"
            });

        Children.Add(
            new NavigationPage(
                new ClientRequestsPage())
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
                new ClientProfilePage())
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