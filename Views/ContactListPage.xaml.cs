using Communication = Microsoft.Maui.ApplicationModel.Communication;
namespace MauiSampleAppFirst.Views;

public partial class ContactListPage : ContentPage
{
	public ContactListPage()
	{
        try
        {
            InitializeComponent();
        }
        catch(Exception ex)
        {

        }
	}

    protected override bool OnBackButtonPressed()
    {
        return false;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        //GetContacts();

        //var contacts = await Microsoft.Maui.ApplicationModel.Communication.Contacts.Default.GetAllAsync();


        //var ets =  GetContactNames();
    }

    private async Task GetContacts()
    {

        var contact = await Communication.Contacts.Default.PickContactAsync();



    }

    private async void SelectContactButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            //var contact = await Contacts.Default.PickContactAsync();

            //if (contact == null)
            //    return;

            //string id = contact.Id;
            //string namePrefix = contact.NamePrefix;
            //string givenName = contact.GivenName;
            //string middleName = contact.MiddleName;
            //string familyName = contact.FamilyName;
            //string nameSuffix = contact.NameSuffix;
            //string displayName = contact.DisplayName;
            //List<ContactPhone> phones = contact.Phones; // List of phone numbers
            //List<ContactEmail> emails = contact.Emails; // List of email addresses
        }
        catch (Exception ex)
        {
            // Most likely permission denied
        }
    }

    public async IAsyncEnumerable<string> GetContactNames()
    {
        var contacts = await Microsoft.Maui.ApplicationModel.Communication.Contacts.Default.GetAllAsync();

        // No contacts
        if (contacts == null)
            yield break;

        foreach (var contact in contacts)
            yield return contact.DisplayName;
    }
}