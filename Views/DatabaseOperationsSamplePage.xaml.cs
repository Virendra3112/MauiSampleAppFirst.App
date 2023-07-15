using MauiSampleAppFirst.Helpers;
using MauiSampleAppFirst.Models;
using System.Collections.ObjectModel;

namespace MauiSampleAppFirst.Views;

public partial class DatabaseOperationsSamplePage : ContentPage
{
    ObservableCollection<Player> players = new ObservableCollection<Player>();
    public ObservableCollection<Player> Players { get { return players; } }

    bool _isEdit = false;
    public bool IsEdit { get { return _isEdit; } }

    Player editItem;

    private ISQLiteOperations<Player> _playerOperations;
    public DatabaseOperationsSamplePage()
    {
        InitializeComponent();
        AddDataPopup.IsVisible = false;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await GetDataAsync();
    }

    private async Task GetDataAsync()
    {
        try
        {
            //activityIndicator.IsVisible = true;
            //await Task.Delay(500);
            _playerOperations = DependencyService.Get<ISQLiteOperations<Player>>();

            var _list = await _playerOperations.GetAllAsync();

            if (_list.Any())
            {
                playersCollectionView.ItemsSource = new ObservableCollection<Player>(_list);
            }
            else
            {

            }

            //activityIndicator.IsVisible = false;

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        AddDataPopup.IsVisible = true;
    }

    private async void Submit_Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            AddDataPopup.IsVisible = false;

            //Get data from entry

            var playerName = playerNameEntry.Text;
            var playerCountry = countryName.Text;

            if (!string.IsNullOrEmpty(playerName) &&
                !string.IsNullOrEmpty(playerCountry))
            {

                if (IsEdit)
                {
                    var updatedItem = editItem;
                    updatedItem.PlayerName = playerName;
                    updatedItem.Country = playerCountry;
                    //Edit item
                    var result = await _playerOperations.UpdateAsync(updatedItem);

                    //Show success popup

                    await DisplayAlert("Success", "Data updated successfully.", "OK");
                }

                else
                {
                    var addData = DependencyService.Get<ISQLiteOperations<Player>>();
                    await addData.InsertAsync(new Player { PlayerName = playerName, Country = playerCountry });
                }
                await GetDataAsync();
            }

            else
            {
                await DisplayAlert("Error", "Please add data and try again", "ok ");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    private void Close_Button_Clicked(object sender, EventArgs e)
    {
        AddDataPopup.IsVisible = false;
        playerNameEntry.Text = string.Empty;
        countryName.Text = string.Empty;
    }

    private async void Delete_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            //activityIndicator.IsVisible = true;

            var _playerId = (int)e.Parameter;

            if (_playerId != 0)
            {
                //get item
                var item = await _playerOperations.GetItemById(_playerId);

                //Delete item
                var result = await _playerOperations.DeleteAsync(item);

                //Show success popup
                //ToDo

                await DisplayAlert("Success", "Item deleted successfully.", "OK");


                //reload data
                await GetDataAsync();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    private async void Edit_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            //activityIndicator.IsVisible = true;

            var _playerId = (int)e.Parameter;

            if (_playerId != 0)
            {
                //get item
                editItem = await _playerOperations.GetItemById(_playerId);

                AddDataPopup.IsVisible = true;

                playerNameEntry.Text = editItem.PlayerName;
                countryName.Text = editItem.Country;

                _isEdit = true;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}