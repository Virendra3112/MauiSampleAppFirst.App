using MauiSampleAppFirst.Helpers;
using MauiSampleAppFirst.Models;

namespace MauiSampleAppFirst.Views;

public partial class DatabaseOperationsSamplePage : ContentPage
{
    public DatabaseOperationsSamplePage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        //var addData = DependencyService.Get<ISQLiteOperations<FlyoutPageItem>>();

        //addData.InsertAsync(new FlyoutPageItem());
    }
}