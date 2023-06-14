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

        CategoryList.Add(new FlyoutPageItem { Title = "CollectionView", MenuIcon = "contacts.png" });
        CategoryList.Add(new FlyoutPageItem { Title = "Tabs", MenuIcon = "contacts.png" });
        CategoryList.Add(new FlyoutPageItem { Title = "Flyout", MenuIcon = "settings.png" });
        CategoryList.Add(new FlyoutPageItem { Title = "Shell Flyout", MenuIcon = "settings.png" });
        CategoryList.Add(new FlyoutPageItem { Title = "CarouselView", MenuIcon = "settings.png" });
        CategoryList.Add(new FlyoutPageItem { Title = "DateTime picker", MenuIcon = "settings.png" });
        CategoryList.Add(new FlyoutPageItem { Title = "Contacts list", MenuIcon = "settings.png" });
        CategoryList.Add(new FlyoutPageItem { Title = "Map", MenuIcon = "settings.png" });

        BindableLayout.SetItemsSource(flexLayout, CategoryList);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var item = e.Parameter as FlyoutPageItem;

        if (item != null)
        {

            switch (item.Title)
            {
                case "CollectionView":
                    Navigation.PushAsync(new CollectionViewSamplePage());
                    break;

                case "Tabs":
                    Navigation.PushAsync(new AppShell());
                    break;

                case "Flyout":
                    Navigation.PushAsync(new FlyoutSamplePage());
                    break;

                case "Shell Flyout":
                    Navigation.PushAsync(new ShellFlyoutSamplePage());
                    break;

                case "CarouselView":
                    Navigation.PushAsync(new CarouselViewSamplePage());

                    break;
                case "DateTime picker": 
                    Navigation.PushAsync(new DateTimePickerSamplePage());
                    break;

                case "Contacts list":
                    Navigation.PushAsync(new ContactListPage());
                    break;
                
                case "Map":
                    Navigation.PushAsync(new ContactListPage());
                    break;
            }
        }
    }
}