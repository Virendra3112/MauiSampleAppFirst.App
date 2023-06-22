using MauiSampleAppFirst.Helpers;
using MauiSampleAppFirst.Models;
using MauiSampleAppFirst.Views;

namespace MauiSampleAppFirst;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //MainPage = new AppShell();

        //MainPage = new FlyoutSamplePage();

        //MainPage = new CarouselViewSamplePage();

        //MainPage = new DateTimePickerSamplePage();

        MainPage = new NavigationPage(new DashboardPage());

        SQLiteHelper.Init();

        DependencyService.Register<ISQLiteOperations<Player>, SQLiteOperations<Player>>();


        //Routing.RegisterRoute("DashboardTabPage/CollectionViewSamplePage", typeof(CollectionViewSamplePage));

    }
}
