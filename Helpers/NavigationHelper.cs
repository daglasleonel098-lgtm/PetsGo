using PetsGo.Views.Admin;
using PetsGo.Views.Client;
using PetsGo.Views.Walker;

namespace PetsGo.Helpers;

public static class NavigationHelper
{
    public static void NavigateByRole(string role)
    {
        if (string.IsNullOrWhiteSpace(role))
            return;

        switch (role)
        {
            case "Client":
                Application.Current.MainPage =
                    new NavigationPage(new ClientHomePage());
                break;

            case "Walker":
                Application.Current.MainPage =
                    new NavigationPage(new WalkerHomePage());
                break;

            case "Admin":
                Application.Current.MainPage =
                    new NavigationPage(new AdminHomePage());
                break;
        }
    }
}