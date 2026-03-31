using wildasdd_mod10_contact_list.Models.ViewModels;

namespace wildasdd_mod10_contact_list.Views;

public partial class HomePage : ContentPage
{
    private ContactsListViewModel contactsViewModel;
    public HomePage()
    {
        InitializeComponent();
        contactsViewModel = new ContactsListViewModel();
        BindingContext = contactsViewModel;

    }

    private void Save_Clicked(object sender, EventArgs e)
    {
        var contactList = new ContactsList();
        contactList.BindingContext = contactsViewModel;
        Navigation.PushAsync(contactList);
    }
}