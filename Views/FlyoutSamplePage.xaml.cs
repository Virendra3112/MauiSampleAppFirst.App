using MauiSampleAppFirst.Models;

namespace MauiSampleAppFirst.Views;

public partial class FlyoutSamplePage : FlyoutPage
{
	public FlyoutSamplePage()
	{
		InitializeComponent();

        flyoutPage.collectionViewFlyout.SelectionChanged += OnSelectionChanged;

    }

        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
            if (item != null)
            {
           
                if (!((IFlyoutPageController)this).ShouldShowSplitMode)
                    IsPresented = false;

                switch (item.Title)
                {
                    case "Home":
                        break;
                
                    case "Contacts":
                    Detail = new NavigationPage(new ContactListPage());

                    break; 
                
                    case "Settings":
                    Detail = new NavigationPage(new SettingsPage());

                    break;
                }
            }
        }
}