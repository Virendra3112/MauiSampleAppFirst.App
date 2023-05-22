namespace MauiSampleAppFirst.Views;

public partial class ContactListPage : ContentPage
{
	public ContactListPage()
	{
		InitializeComponent();
	}

    protected override bool OnBackButtonPressed()
    {
        return false;
    }
}