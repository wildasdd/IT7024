namespace wildasdd_Mod7_SignUp;
[QueryProperty(nameof(Username), "username")]
[QueryProperty(nameof(Email), "email")]

public partial class Profile : ContentPage
{
    public string Username { get; set; }
    public string Email { get; set; }
    public Profile()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        UsernameLabel.Text = $"Username: {Username}";
        EmailLabel.Text = $"Email: {Email}";
    }
    private void SignOut_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}