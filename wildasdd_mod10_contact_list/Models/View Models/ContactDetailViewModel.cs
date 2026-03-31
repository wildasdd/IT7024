using CommunityToolkit.Mvvm.ComponentModel;

namespace wildasdd_mod10_contact_list.Models.ViewModels;

partial class ContactDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Contact contact;
}