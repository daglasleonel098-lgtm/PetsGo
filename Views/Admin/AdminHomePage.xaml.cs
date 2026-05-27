namespace PetsGo.Views.Admin;

public partial class AdminHomePage : ContentPage
{
    public AdminHomePage()
    {
        InitializeComponent();
    }

    private async void OnUsers(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdminUsersPage());
    }
}
