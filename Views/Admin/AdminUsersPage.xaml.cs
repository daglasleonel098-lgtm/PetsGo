using PetsGo.Services;

namespace PetsGo.Views.Admin;

public partial class AdminUsersPage : ContentPage
{
    public AdminUsersPage()
    {
        InitializeComponent();

        UsersList.ItemsSource =
            DataService.GetUsers();
    }
}