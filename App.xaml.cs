using PetsGo.Views;

namespace PetsGo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage =
            new NavigationPage(
                new LoginPage());
    }
}