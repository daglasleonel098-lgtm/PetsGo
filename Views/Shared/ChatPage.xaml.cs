namespace PetsGo.Views.Shared;

public partial class ChatPage : ContentPage
{
    private List<ChatMessage> Messages =
        new();

    public ChatPage()
    {
        InitializeComponent();

        MessagesList.ItemsSource = Messages;
    }

    private void OnSendClicked(
        object sender,
        EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(
            MessageEntry.Text))
            return;

        Messages.Add(
            new ChatMessage
            {
                User = "Tú",
                Message = MessageEntry.Text
            });

        MessagesList.ItemsSource = null;
        MessagesList.ItemsSource = Messages;

        MessageEntry.Text = "";
    }
}

public class ChatMessage
{
    public string User { get; set; } = "";

    public string Message { get; set; } = "";
}