using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai4 : ContentPage
    {
        public Bai4()
        {
            InitializeComponent();
            createLocation();
        }

        private void listLocation_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listLocation.SelectedItem != null)
            {
                City location = (City)listLocation.SelectedItem;
                Navigation.PushAsync(new Hotel(location));
            }
        }

        List<City> cityList = new List<City>();

        void createLocation()
        {
            cityList.Add(new City { cityCode = "HN", cityName = "Thủ đô Hà Nội", cityImg = "binhdinh.jpg" });
            cityList.Add(new City { cityCode = "HCM", cityName = "Thành phố Hồ Chí Minh", cityImg = "hcm.jpg" });
            cityList.Add(new City { cityCode = "BD", cityName = "Bình Định", cityImg = "binhdinh.jpg" });
            cityList.Add(new City { cityCode = "DN", cityName = "Đà Nẵng", cityImg = "hcm.jpg" });

            listLocation.ItemsSource = cityList;
        }
    }
}