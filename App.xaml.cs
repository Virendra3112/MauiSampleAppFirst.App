using MauiSampleAppFirst.Views;

namespace MauiSampleAppFirst;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();

        //MainPage = new FlyoutSamplePage();

        MainPage = new ShellFlyoutSamplePage();

        Routing.RegisterRoute("DashboardTabPage/CollectionViewSamplePage", typeof(CollectionViewSamplePage));

    }
}
