using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiSampleAppFirst.Views
{

    public partial class DashboardTabPage : ContentPage, INotifyPropertyChanged
    {
        private ObservableCollection<Item> _categoryList;

        public ObservableCollection<Item> CategoryList
        {
            get { return _categoryList; }
            set { _categoryList = value; NotifyPropertyChanged(); }
        }

        private bool setDarkMode;

        public bool SetDarkMode
        {
            get
            {
                return setDarkMode;
            }
            set
            {
                setDarkMode = value;
                NotifyPropertyChanged();

                //SetTheme(setDarkMode);
            }
        }
        public DashboardTabPage()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            CategoryList = new ObservableCollection<Item>();
            
            CategoryList.Add(new Item { Name = "CollectionView", Image = "icon.png" });
            CategoryList.Add(new Item { Name = "Layouts", Image = "icon.png" });
            CategoryList.Add(new Item { Name = "FlyoutPage", Image = "icon.png" });

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Item SelectedItem = CategoryList.FirstOrDefault(itm => itm.Name == ((TappedEventArgs)e).Parameter.ToString());

            if (SelectedItem != null)
            {
                switch (SelectedItem.Name)
                {

                    case "CollectionView":
                        {
                            Navigation.PushAsync(new CollectionViewSamplePage());
                            //Shell.Current.Navigation.PushAsync(new CollectionViewSamplePage());

                            //Shell.Current.GoToAsync("DashboardTabPage/CollectionViewSamplePage");

                            break;
                        }
                    
                    case "Layouts":
                        {
                            Navigation.PushAsync(new LayoutsPage(),true);

                            break;
                        }
                        
                    default:
                        break;



                }
            }

        }


    }
    public class Item
    {
        public string Name { get; set; }

        public string Image { get; set; }

    }


}