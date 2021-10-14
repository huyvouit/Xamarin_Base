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
    public partial class Hotel : ContentPage
    {
        public Hotel()
        {
            InitializeComponent();
        }

        public Hotel(City location)
        {
            InitializeComponent();
            Title = location.cityName;
            InitHotel(location);
        }

        void InitHotel(City local)
        {
            List<InfoHotel> hotelList = new List<InfoHotel>();

            if(local.cityCode == "HN")
            {
                hotelList.Add(new InfoHotel 
                { 
                    hotelID = "HN01",
                    hotelName = "HN Luxury",
                    hotelAddress = "10 Quang Trung Street, Q.Cau Giay, HN",
                    hotelIntro = "Trung tâm thủ đô Hà nội",
                    hotelImg = "hanoi.jpg",

                });hotelList.Add(new InfoHotel 
                { 
                    hotelID = "HN01",
                    hotelName = "HN Plaza",
                    hotelAddress = "10 Quang Trung Street, Q.Cau Giay, HN",
                    hotelIntro = "Trung tâm thủ đô Hà nội",
                    hotelImg = "hanoi.jpg",

                });
            }

            else if (local.cityCode == "HCM")
            {
                hotelList.Add(new InfoHotel
                {
                    hotelID = "HCM01",
                    hotelName = "HCM Bitcon",
                    hotelAddress = "156 Nguyen Hue Street, Q.1, HCM",
                    hotelIntro = "Trung tâm thủ đô Hà nội",
                    hotelImg = "hanoi.jpg",

                }); hotelList.Add(new InfoHotel
                {
                    hotelID = "HCM02",
                    hotelName = "HCM UIT",
                    hotelAddress = "56 Hai Bà Trưng Street, Q.1, HCM",
                    hotelIntro = "Trung tâm thủ đô Hà nội",
                    hotelImg = "hanoi.jpg",

                });
            }

            else if (local.cityCode == "BD")
            {
                hotelList.Add(new InfoHotel
                {
                    hotelID = "BD01",
                    hotelName = "Binh Dinh Luxury",
                    hotelAddress = "10 An Duong Vuong Street, Quy Nhơn, BD",
                    hotelIntro = "Sang trọng, quý phái",
                    hotelImg = "hanoi.jpg",

                }); hotelList.Add(new InfoHotel
                {
                    hotelID = "BD02",
                    hotelName = "Binh Dinh FLC",
                    hotelAddress = "10 Quang Trung Street, Quy Nhon, BD",
                    hotelIntro = "Đẳng cấp, chuẩn 5 sao",
                    hotelImg = "hanoi.jpg",

                });
            }

            else if (local.cityCode == "DN")
            {
                hotelList.Add(new InfoHotel
                {
                    hotelID = "HN01",
                    hotelName = "Da Nang Luxury",
                    hotelAddress = "10 Quang Trung Street, Q.Hai Chau",
                    hotelIntro = "Trung tâm thành phố Đà Nẵng",
                    hotelImg = "hanoi.jpg",

                }); hotelList.Add(new InfoHotel
                {
                    hotelID = "HN01",
                    hotelName = "Da Nang PenHouse",
                    hotelAddress = "179 Đong Khoi Street, Q.Hai Chau, Da Nang",
                    hotelIntro = "Cách cầu rồng 500m",
                    hotelImg = "hanoi.jpg",

                });
            }
            listHotel.ItemsSource = hotelList;
        }
    }
}