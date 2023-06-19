using MauiSampleAppFirst.Models;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace MauiSampleAppFirst.Views;

public partial class CollectionViewSamplePage : ContentPage
{
    ObservableCollection<Player> players = new ObservableCollection<Player>();
    public ObservableCollection<Player> Players { get { return players; } }

    public CollectionViewSamplePage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        LoadData();

    }

    private void LoadData()
    {
        players.Add(new Player { PlayerName = "Virat Kohi", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerName = "Rohit Sharma", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerName = "Shubhman Gill", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerName = "Shikhar Dhawan", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerName = "Suryakumar Yadav", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerName = "MahendraSingh Dhoni", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerName = "Jasprit Bumrah", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerName = "Hardik Pandya", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerName = "Shreyes Iyer", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerName = "Rishabh Pant", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerName = "Rvindra Jadeja", PlayerImage = "icon.png", Country = "INDIA" });

        playersCollectionView.ItemsSource = players;

    }

    private void LastItemButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            playersCollectionView.ScrollTo(players.Count);

        }
        catch (Exception ex)
        {

        }
    }

    private void FirstItemButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            playersCollectionView.ScrollTo(1);
        }
        catch (Exception ex)
        {

        }
    }
}