using MauiSampleAppFirst.Models;
using System.Collections.ObjectModel;

namespace MauiSampleAppFirst.Views;

public partial class FlyoutMenuPage : ContentPage
{

    ObservableCollection<FlyoutPageItem> flyoutPageItems = new ObservableCollection<FlyoutPageItem>();
    public ObservableCollection<FlyoutPageItem> FlyoutPageItems { get { return flyoutPageItems; } }
    public FlyoutMenuPage()
	{
		InitializeComponent();
        flyoutPageItems.Add(new FlyoutPageItem { Title = "Home", MenuIcon = "Home.png" });
        flyoutPageItems.Add(new FlyoutPageItem { Title = "Contacts", MenuIcon = "Contacts.png" });
        flyoutPageItems.Add(new FlyoutPageItem { Title = "Settings", MenuIcon = "Settings.png" });

        collectionViewFlyout.ItemsSource = flyoutPageItems;
    }
}