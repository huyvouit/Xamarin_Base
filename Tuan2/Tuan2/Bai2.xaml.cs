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
    public partial class Bai2 : ContentPage
    {
        public Bai2()
        {
            InitializeComponent();
            createCityCollection();
        }

        List<City> cityList = new List<City>();

        void createCityCollection()
        {
            cityList.Add(new City { cityCode = "HN", cityName = "Thủ đô Hà Nội", cityImg = "hanoi.jpg" });
            cityList.Add(new City { cityCode = "HCM", cityName = "Thành phố Hồ Chí Minh", cityImg = "hcm.jpg" });
            cityList.Add(new City { cityCode = "BD", cityName = "Bình Định", cityImg = "binhdinh.jpg" });

            listCity.ItemsSource = cityList;
        }
    }
}