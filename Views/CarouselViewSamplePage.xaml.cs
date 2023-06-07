using System.Collections.ObjectModel;

namespace MauiSampleAppFirst.Views;

public partial class CarouselViewSamplePage : ContentPage
{
    ObservableCollection<Player> players = new ObservableCollection<Player>();
    public ObservableCollection<Player> Players { get { return players; } }
    public CarouselViewSamplePage()
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
        players.Add(new Player { PlayerId = 1, PlayerName = "Virat Kohi", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerId = 2, PlayerName = "Rohit Sharma", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerId = 3, PlayerName = "Shubhman Gill", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerId = 4, PlayerName = "Shikhar Dhawan", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerId = 5, PlayerName = "Suryakumar Yadav", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerId = 6, PlayerName = "MahendraSingh Dhoni", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerId = 7, PlayerName = "Jasprit Bumrah", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerId = 8, PlayerName = "Hardik Pandya", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerId = 9, PlayerName = "Shreyes Iyer", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerId = 10, PlayerName = "Rishabh Pant", PlayerImage = "icon.png", Country = "INDIA" });
        players.Add(new Player { PlayerId = 11, PlayerName = "Rvindra Jadeja", PlayerImage = "icon.png", Country = "INDIA" });

        carouselView.ItemsSource = players;

    }
}