namespace Lab1.Maui.Views;

public partial class EditContact : ContentPage
{
	public EditContact()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}