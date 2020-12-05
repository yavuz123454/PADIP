using PADIP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PADIP.NavigationPagesFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EPDS : ContentPage
    {
        List<Olcek> myRealList = new List<Olcek>();
        int puan = 0;
        public EPDS()
        {
            InitializeComponent();
            DisplayAlert("EPDS ölçeği", "Geçen son bir hafta içindeki duygularınızı ve düşüncelerinizi en iyi tanımlayan ifadeyi işaretleyiniz.", "tamam");
            var myList = new List<Olcek>
            {
                new Olcek { SoruEPDS = "1-Gülebiliyor ve olayların komik tarafını görebiliyorum", Numara = "1"},

                new Olcek {SoruEPDS = "2-Geleceğe hevesle bakıyorum", Numara ="2"},

                new Olcek {SoruEPDS ="3-Bir şeyler kötü gittiğinde gereksiz yere kendimi suçluyorum",Numara ="3"},

                new Olcek { SoruEPDS = "4-Nedensiz yere kendimi sıkıntılı ya da endişeli hissediyorum", Numara = "1"},

                new Olcek {SoruEPDS = "5-İyi bir nedeni olmadığı halde, korkuyor ya da panikliyorum", Numara ="2"},

                new Olcek {SoruEPDS ="6-Her şey giderek sırtıma yükleniyor",Numara ="3"},
                new Olcek { SoruEPDS ="7-Öylesine mutsuzum ki uyumakta zorlanıyorum", Numara = "1"},

                new Olcek {SoruEPDS = "8-Kendimi üzüntülü ya da çökkün hissediyorum", Numara ="2"},

                new Olcek {SoruEPDS ="9-Öylesine mutsuzum ki ağlıyorum",Numara ="3"},

                new Olcek { SoruEPDS = "10-Kendime zarar verme düşüncesinin aklıma geldiği oldu", Numara = "1"},

                new Olcek {SoruEPDS = "11-Öylesine mutsuzum ki içimden ağlamak geliyor, ağlamak istiyorum ama ağlayamıyorum", Numara ="2"},

             


            };

            myRealList = myList;

            myListView.ItemsSource = myRealList;
        }


        private async void btnpass_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Edinburg Doğum Sonrası Depresyon Ölçeği", "Puanınız:" + puan, "tamam");
            await Navigation.PushAsync(new PSQI());
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void CheckBox_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
        {
            puan = puan + 1;
        }

        private void CheckBox_CheckedChanged_2(object sender, CheckedChangedEventArgs e)
        {
            puan = puan + 2;
        }

        private void CheckBox_CheckedChanged_3(object sender, CheckedChangedEventArgs e)
        {
            puan = puan + 3;
        }

        private void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            myListView.SelectedItem = null;
        }

        private void myListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}