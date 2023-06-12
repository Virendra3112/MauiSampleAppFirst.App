using MauiSampleAppFirst.Models;
using System.Collections.ObjectModel;

namespace MauiSampleAppFirst.Views;

public partial class DashboardPage : ContentPage
{
    ObservableCollection<FlyoutPageItem> categoryList = new ObservableCollection<FlyoutPageItem>();
    public ObservableCollection<FlyoutPageItem> CategoryList { get { return categoryList; } }
    public DashboardPage()
	{
		InitializeComponent();

        CategoryList.Add(new FlyoutPageItem { Title = "Contacts", MenuIcon = "contacts.png" });
        CategoryList.Add(new FlyoutPageItem { Title = "Settings", MenuIcon = "settings.png" });

       BindableLayout.SetItemsSource(flexLayout, CategoryList);
	}
}