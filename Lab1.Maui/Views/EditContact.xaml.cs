using Lab1.Maui.Models;
using Contact = Lab1.Maui.Models.Contact;



namespace Lab1.Maui.Views;

[QueryProperty(nameof(ContactId),"Id")]
public partial class EditContact : ContentPage
{
	private Contact contact;
	public EditContact()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

	public string ContactId
	{
		set
		{
			contact = ContactRepository.GetContactById(int.Parse(value));
			lblName.Text = contact.Name;
		}
	}
	
}