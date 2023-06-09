using System.Collections.ObjectModel;
using Communication = Microsoft.Maui.ApplicationModel.Communication;
namespace MauiSampleAppFirst.Views;

public partial class ContactListPage : ContentPage
{
    ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
    public ObservableCollection<Contact> Contacts { get { return contacts; } }


    int count = 0;

    public int Count { get { return count; } }
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

    protected async override void OnAppearing()
    {
        base.OnAppearing();

       await GetContacts();
    }

    private async Task GetContacts()
    {

        var contactsData = await Communication.Contacts.Default.GetAllAsync();

        if (contactsData == null)
             return;

        foreach (var item in contactsData.Take(50))
        {
            contacts.Add(new Contact( item.DisplayName,  item.Id));
        }

        contactsCollectionView.ItemsSource = contacts;
        count = contacts.Count;
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

    public class Contact
    {
        string name;
        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
                if (Photo == null)
                {
                    string resourceName = value.Replace(" ", "").ToLower() + ".jpg";
                    Photo = ImageSource.FromFile(resourceName);
                }
            }
        }

        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        public ImageSource Photo { get; set; }
        public string Phone { get; set; }
    }
}