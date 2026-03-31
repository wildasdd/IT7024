using wildasdd_mod10_contact_list.Views;

namespace wildasdd_mod10_contact_list
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }
    }
}
