using wildasdd_mod10_contact_list.Models.ViewModels;
using wildasdd_mod10_contact_list.Models;

namespace wildasdd_mod10_contact_list.Views;

public partial class ContactsList : ContentPage
{
    public ContactsList()
    {
       InitializeComponent();
    }

    private void List_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var contact = e.Item as Contact;
        var contactViewModel = new ContactDetailViewModel { Contact = contact };
        var contactDetail = new ContactDetail();
        contactDetail.BindingContext = contactViewModel;
        Navigation.PushAsync(contactDetail);

    }
}