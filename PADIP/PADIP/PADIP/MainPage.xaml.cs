using PADIP.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PADIP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Olcek> myRealList = new List<Olcek>();
        int puan = 0;
       
       
        public MainPage()
        {
            InitializeComponent();
             DisplayAlert("Perinatal Anksiyete Tarama Ölçeği", "Aşağıdakileri geçtiğimiz ay ne sıklıkla yaşadınız? Lütfen her Soru için yaşadıklarınıza en yakın olan yanıtı işaretleyiniz.", "tamam");
            var myList = new List<Olcek>
            {
                new Olcek { SoruPASS = "1-Bebek / gebelik ile ilgili endişe", Numara = "1"},
                
                new Olcek {SoruPASS = "2-Bebeğe zarar geleceği ile ilgili korku", Numara ="2"},
                
                new Olcek {SoruPASS ="3-Bir şeylerin kötü gideceğine dair korku hissi",Numara ="3"},
                new Olcek { SoruPASS = "4-Pek çok şey hakkında endişelenme", Numara = "1"},

                new Olcek {SoruPASS = "5-Gelecek hakkında endişe", Numara ="2"},

                new Olcek {SoruPASS ="6-Birşeylerin üstüne fazla yüklendiğini hissesetme",Numara ="3"},
                new Olcek { SoruPASS ="7-İğne, kan, doğum, ağrı vb. şeyler konusunda çok şiddetli korkular", Numara = "1"},

                new Olcek {SoruPASS = "8-Birden bastıran aşırı korku veya huzursuzluk", Numara ="2"},

                new Olcek {SoruPASS ="9-Durdurulması veya kontrol edilmesi zor olan, tekrarlayan düşünceler",Numara ="3"},

                new Olcek { SoruPASS = "10-Uyumak için fırsatım olsa bile uyumakta zorlanma", Numara = "1"},

                new Olcek {SoruPASS = "11-İşleri belirli bir düzen veya sıra ile yapmak zorunda hissetme", Numara ="2"},

                new Olcek {SoruPASS ="12-Herşeyin mükemmel olmasını isteme ",Numara ="3"},
                new Olcek { SoruPASS = "13-Herşeyi kontrol etme ihtiyacı", Numara = "1"},

                new Olcek {SoruPASS = "14-Birşeyleri defalarca kontrol etmeyi veya yapmayı durdurmakta zorluk", Numara ="2"},

                new Olcek {SoruPASS ="15-Diken üstünde hissetme veya kolayca irkilme",Numara ="3"},
                new Olcek { SoruPASS = "16-Tekrarlayan düşüncelerin yol açtığı rahatsızlık /sıkıntı", Numara = "1"},

                new Olcek {SoruPASS = "17-Birşeyler için tetikte olma ya da dikkatli olma ihtiyacı", Numara ="2"},

                new Olcek {SoruPASS ="18-Tekrarlayan anılar, rüyalar ya da kabuslardan dolayı üzülme, sıkıntı çekme",Numara ="3"},
                new Olcek { SoruPASS = "19-Başkalarının önünde kendimi rezil edeceğim endişesi", Numara = "1"},

                new Olcek {SoruPASS = "20-Diğer insanların beni olumsuz yargılayacağı korkusu", Numara ="2"},

                new Olcek {SoruPASS ="21-Kalabalık içinde fazla rahatsız hissetme",Numara ="3"},
                new Olcek {SoruPASS = "22-Huzursuz olacağım korkusu ile sosyal aktivitelerden kaçınma", Numara ="2"},

                new Olcek {SoruPASS ="23-Huzursuz eden şeylerden kaçınma",Numara ="3"},
                new Olcek { SoruPASS = "24-Kendinizi sanki bir filmde izliyormuş gibi kopuk hissetme", Numara = "1"},

                new Olcek {SoruPASS = "25-Zamanın nasıl geçtiğini farkedememe ve ne olduğunu hatırlayamama ", Numara ="2"},

                new Olcek {SoruPASS ="26-Yakın zamanda olan değişikliklere uyum sağlamakta zorluk",Numara ="3"},
                new Olcek { SoruPASS = "27-Birşeyler yapabilmenize engel olan kaygı", Numara = "1"},

                new Olcek {SoruPASS = "28-Konsantre olmayı güçleştiren yarışan düşünceler", Numara ="2"},

                new Olcek {SoruPASS ="29-Kontrolünü kaybetme korkusu",Numara ="3"},
                new Olcek { SoruPASS = "30-Paniklemiş hissetme", Numara = "1"},

                new Olcek {SoruPASS = "31-Tedirgin (ajite) hissetme, kıpırdanma", Numara ="2"},

            

            };

            myRealList = myList;

            myListView.ItemsSource = myRealList;
           
        }

        private void btnpass_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Perinatal Anksiyete Tarama Ölçeği", "Puanınız:"+puan, "tamam");
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
    }
}
