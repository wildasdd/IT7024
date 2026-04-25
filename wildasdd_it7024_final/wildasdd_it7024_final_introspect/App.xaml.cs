namespace wildasdd_it7024_final_introspect
{
    public partial class App : Application
    {
        public App(LocalDBService dbService)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage(dbService));
        }
    }
}
