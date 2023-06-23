using MauiSampleAppFirst.Helpers;
using MauiSampleAppFirst.Models;
using System.Collections.ObjectModel;

namespace MauiSampleAppFirst.Views;

public partial class DatabaseOperationsSamplePage : ContentPage
{
    ObservableCollection<Player> players = new ObservableCollection<Player>();
    public ObservableCollection<Player> Players { get { return players; } }

    //bool isAddPopupVisible = false;
    //public bool IsAddPopupVisible { get { return isAddPopupVisible; } }
    public DatabaseOperationsSamplePage()
    {
        InitializeComponent();
        AddDataPopup.IsVisible = false;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var addData = DependencyService.Get<ISQLiteOperations<Player>>();

        var _list = await addData.GetAllAsync();

        if (_list.Any())
        {
            playersCollectionView.ItemsSource = new ObservableCollection<Player>(_list);
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        AddDataPopup.IsVisible = true;
    }

    private void Submit_Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            AddDataPopup.IsVisible = false;

            //Get data from entry

            var plaerName = playerNameEntry.Text;
            var plaerCountry = countryName.Text;

            if (!string.IsNullOrEmpty(plaerName) &&
                !string.IsNullOrEmpty(plaerCountry))
            {

                var addData = DependencyService.Get<ISQLiteOperations<Player>>();

                addData.InsertAsync(new Player { PlayerName = plaerName, Country = plaerCountry });

            }

            else
            {
                //error popup
            }


            //refresh data 
        }
        catch (Exception ex)
        {

        }
    }

    private void Close_Button_Clicked(object sender, EventArgs e)
    {
        AddDataPopup.IsVisible = false;
        playerNameEntry.Text = string.Empty;
        countryName.Text = string.Empty;
    }
}