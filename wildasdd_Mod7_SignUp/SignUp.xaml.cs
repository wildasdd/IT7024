namespace wildasdd_Mod7_SignUp
{
    public partial class SignUp : ContentPage
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpClicked(object sender, EventArgs e)
        {

            var profile_info = new Dictionary<string, object>
                {
                    {"username",$"{Username.Text}" },
                    {"email", $"{Email.Text}" },
                    {"password", $"{Password.Text}" },
                    {"confirmpassword", $"{ConfirmPassword.Text}" }
                };

            string username = Username.Text;
            string email = Email.Text;
            string pw = Password.Text;
            string cpw = ConfirmPassword.Text;

            if (( username != "" && email != "" && pw != "" && cpw != "")
                && pw != cpw)
                DisplayAlert("Error","Passwords do not match.", "OK");
            else if ((username != "" && email != "" && pw != "" && cpw != "")
                && pw == cpw)
                Shell.Current.GoToAsync(nameof(Profile), profile_info);
            else DisplayAlert("Error", "Missing information.", "OK");
        }
    }
}
