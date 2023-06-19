using MauiSampleAppFirst.Models;
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
        players.Add(new Player {  PlayerImage = "https://img.freepik.com/free-vector/digital-technology-search-engine-optimization-website-constructor_335657-2471.jpg"});
        players.Add(new Player {  PlayerImage = "https://www.kasandbox.org/programming-images/avatars/spunky-sam-green.png", });
        players.Add(new Player {  PlayerImage  = "https://www.kasandbox.org/programming-images/avatars/marcimus-red.png" });
        players.Add(new Player {  PlayerImage = "https://www.kasandbox.org/programming-images/avatars/old-spice-man-blue.png" });
        players.Add(new Player {  PlayerImage  = "https://www.kasandbox.org/programming-images/avatars/mr-pants-purple.png" });
        players.Add(new Player {  PlayerImage = "https://www.kasandbox.org/programming-images/avatars/old-spice-man.png" });
       

        carouselView.ItemsSource = players;

    }
}