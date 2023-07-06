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

        var test = "<h1>This is a Heading </br> </br> test</h1>\r\n<p>This is a paragraph.</p>";

        //customLabel.Text = test;


        CategoryList.Add(new FlyoutPageItem { Title = "SQLite Operations", MenuIcon = "settings.png", Page = new DatabaseOperationsSamplePage() });
        CategoryList.Add(new FlyoutPageItem { Title = "CollectionView", MenuIcon = "contacts.png", Page = new CollectionViewSamplePage() });
        CategoryList.Add(new FlyoutPageItem { Title = "Tabs", MenuIcon = "contacts.png", Page = new AppShell() });
        CategoryList.Add(new FlyoutPageItem { Title = "Flyout", MenuIcon = "settings.png", Page = new FlyoutSamplePage() });
        CategoryList.Add(new FlyoutPageItem { Title = "Shell Flyout", MenuIcon = "settings.png", Page = new ShellFlyoutSamplePage() });
        CategoryList.Add(new FlyoutPageItem { Title = "CarouselView", MenuIcon = "settings.png", Page = new CarouselViewSamplePage() });
        CategoryList.Add(new FlyoutPageItem { Title = "DateTime picker", MenuIcon = "settings.png", Page = new DateTimePickerSamplePage() });
        CategoryList.Add(new FlyoutPageItem { Title = "Contacts list", MenuIcon = "settings.png", Page = new ContactListPage() });
        CategoryList.Add(new FlyoutPageItem { Title = "Shapes", MenuIcon = "settings.png", Page = new ShapesSamplePage() });

        BindableLayout.SetItemsSource(flexLayout, CategoryList);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var item = e.Parameter as FlyoutPageItem;

        if (item != null)
        {
            if (item.Page != null)
                NavigateTo(item.Page);

            //switch (item.Title)
            //{
            //    case "CollectionView":
            //        Navigation.PushAsync(new CollectionViewSamplePage());
            //        break;

            //    case "Tabs":
            //        Navigation.PushAsync(new AppShell());
            //        break;

            //    case "Flyout":
            //        Navigation.PushAsync(new FlyoutSamplePage());
            //        break;

            //    case "Shell Flyout":
            //        Navigation.PushAsync(new ShellFlyoutSamplePage());
            //        break;

            //    case "CarouselView":
            //        Navigation.PushAsync(new CarouselViewSamplePage());

            //        break;
            //    case "DateTime picker":
            //        Navigation.PushAsync(new DateTimePickerSamplePage());
            //        break;

            //    case "Contacts list":
            //        Navigation.PushAsync(new ContactListPage());
            //        break;

            //    case "SQLite Operations":
            //        Navigation.PushAsync(new DatabaseOperationsSamplePage());
            //        break;

            //    case "Shapes":
            //        Navigation.PushAsync(new ShapesSamplePage());
            //        break;
            //}
        }
    }

    private void NavigateTo(Page page)
    {
        try
        {
            Navigation.PushAsync(page);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}