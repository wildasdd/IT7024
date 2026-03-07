namespace wildasdd_Mod7_SignUp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SignUp), typeof(SignUp));
            Routing.RegisterRoute(nameof(Profile), typeof(Profile));
        }
    }
}
