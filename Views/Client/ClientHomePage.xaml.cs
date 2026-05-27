using PetsGo.Managers;
using PetsGo.Services;
using PetsGo.Views.Shared;

namespace PetsGo.Views.Client;

public partial class ClientHomePage : ContentPage
{
    public ClientHomePage()
    {
        InitializeComponent();
    }

    private async void OnMapClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientMapPage());
    }

    private async void OnRequestsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientRequestsPage());
    }

    private async void OnChatClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChatPage());
    }

    private async void OnRequestWalkClicked(object sender, EventArgs e)
    {
        string clientName = "Cliente";

        if (AuthService.CurrentUser != null)
        {
            clientName = AuthService.CurrentUser.Name;
        }

        RequestManager.CreateRequest(clientName);

        await DisplayAlert(
            "Éxito",
            "Solicitud enviada correctamente",
            "OK");
    }
}