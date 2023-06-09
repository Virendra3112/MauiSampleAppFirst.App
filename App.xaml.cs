using MauiSampleAppFirst.Views;

namespace MauiSampleAppFirst;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();

        //MainPage = new FlyoutSamplePage();

        MainPage = new CarouselViewSamplePage();

        Routing.RegisterRoute("DashboardTabPage/CollectionViewSamplePage", typeof(CollectionViewSamplePage));

    }
}
