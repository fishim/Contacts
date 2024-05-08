using Lab1.Maui.Models;
using Contact = Lab1.Maui.Models.Contact;
namespace Lab1.Maui.Views;

public partial class ContactsPage : ContentPage
{

    public ContactsPage()
    {
        InitializeComponent();

        List<Contact> contacts = ContactRepository.GetContacts();

        listContacts.ItemsSource = contacts;

    }

   

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listContacts.SelectedItem != null)
        {
            await Shell.Current.GoToAsync($"{nameof(EditContact)}?Id={((Contact)listContacts.SelectedItem).ContactId}");
        }
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
    }
}