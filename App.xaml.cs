using MauiSampleAppFirst.Views;

namespace MauiSampleAppFirst;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        Routing.RegisterRoute("DashboardTabPage/CollectionViewSamplePage", typeof(CollectionViewSamplePage));

    }
}
