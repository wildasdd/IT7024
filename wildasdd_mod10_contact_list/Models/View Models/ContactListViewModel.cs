using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace wildasdd_mod10_contact_list.Models.ViewModels;

partial class ContactsListViewModel:ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Contact> contacts = new();

    [ObservableProperty]
    private Contact contact = new();

    [RelayCommand]

    private void Add()
    {
        Contacts.Add(Contact);
        Contact = new();
    }
}