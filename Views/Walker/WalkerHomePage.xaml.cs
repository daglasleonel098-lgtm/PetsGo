using PetsGo.Services;
using PetsGo.Views.Shared;

namespace PetsGo.Views.Walker;

public partial class WalkerHomePage : ContentPage
{
    public WalkerHomePage()
    {
        InitializeComponent();

        if (AuthService.CurrentUser != null)
        {
            WelcomeLabel.Text =
                $"Bienvenido, {AuthService.CurrentUser.Name}";
        }
    }

    private async void OnRequestsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WalkerRequestsPage());
    }

    private async void OnProfileClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WalkerProfilePage());
    }

    private async void OnChatClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChatPage());
    }
}