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
    public partial class Bai3 : ContentPage
    {
        public Bai3()
        {
            InitializeComponent();
            createMonkeyList();
        }

        List<Monkey> Monkeys = new List<Monkey>();

        void createMonkeyList()
        {
            Monkeys.Add(new Monkey { name = "Grey Monkey", location = "Việt Nam", img = "hanoi.jpg" });
            Monkeys.Add(new Monkey { name = "Green Monkey", location = "Thái Lan", img = "hanoi.jpg" });
            Monkeys.Add(new Monkey { name = "Yellow Monkey", location = "Lào", img = "hanoi.jpg" });
            Monkeys.Add(new Monkey { name = "Blue Monkey", location = "Indonesia", img = "hanoi.jpg" });
           
            listMonkey.ItemsSource = Monkeys;
        }
    }
}