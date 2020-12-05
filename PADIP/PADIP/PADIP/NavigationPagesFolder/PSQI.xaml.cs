using PADIP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace PADIP.NavigationPagesFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PSQI : ContentPage
    {
       public List<Olcek> myRealList = new List<Olcek>();
        

        public PSQI()
        {
            

            InitializeComponent();
          

            DisplayAlert("PİTTSBURGH UYKU KALİTESİ İNDEKSİ", "Aşağıdaki sorulara vereceğiniz cevaplar için son 1 ayı göz önünde bulundurun", "tamam");
            

        var myList = new List<Olcek>
            {
                new Olcek { SoruPSQI = "1-Geçen ay, geceleri genellikle ne zaman yattınız? Mutat yatış saati: ", Numara = "1",Soru="false",Soruters="true",Soruters2="false",Tptime="10"},

                new Olcek {SoruPSQI = "2-Geçen ay, gece uykuya dalmanız genellikle ne kadar zaman (dakika olarak) aldı? ", Numara ="2",Soru="false",Soruters="false",Soruters2="true",Tptime="10"},

                new Olcek {SoruPSQI ="3-Geçen ay, sabahları genellikle ne zaman kalktınız? Mutat kalkış saati: ",Numara ="3",Soru="false",Soruters="true",Soruters2="false",Tptime="10"},
                new Olcek { SoruPSQI = "4-Geçen ay, geceleri gerçekten kaç saat uyudunuz? ", Numara = "4",Soru="false",Soruters="false",Soruters2="true",Tptime="10"},

                new Olcek {SoruPSQI = "5-30 dakika içinde uykuya dalamadınız ", Numara ="5",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},

                new Olcek {SoruPSQI ="6-Gece yarısı veya sabah erken uyandınız ",Numara ="6",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},
                new Olcek { SoruPSQI ="7-Banyo yapmak için kalkmak zorunda kaldınız ", Numara = "7",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},

                new Olcek {SoruPSQI = "8-Rahat bir şekilde nefes alıp veremediniz ", Numara ="8",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},

                new Olcek {SoruPSQI ="9-Öksürdünüz veya gürültülü bir şekilde horladınız ",Numara ="9",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},

                new Olcek { SoruPSQI = "10-Aşırı derecede üşüdünüz ", Numara = "10",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},

                new Olcek {SoruPSQI = "11-Aşırı derecede sıcaklık hissettiniz ", Numara ="11",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},

                new Olcek {SoruPSQI ="12-- Kötü rüya gördünüz  ",Numara ="12",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},
                new Olcek { SoruPSQI = "13-Ağrı duydunuz ", Numara = "13",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},

                new Olcek {SoruPSQI = "14-Diğer neden (ler), lütfen belirtiniz", Numara ="14",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},

                
                new Olcek { SoruPSQI = "15-Geçen ay uyku kalitenizi bütünüyle nasıl değerlendirebilirsiniz? ", Numara = "15",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Çok iyi",Cevap2="Oldukça iyi",Cevap3="Oldukça kötü",Cevap4="Çok kötü"},

                new Olcek {SoruPSQI = "16-Geçen ay uyumanıza yardımcı olması için ne kadar sıklıkla uyku ilacı (reçeteli veya reçetesiz) aldınız ? ", Numara ="16",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="Haftada 1'den az",Cevap3="Haftada 1-2 Kez",Cevap4="Haftada 3'den çok"},

                new Olcek {SoruPSQI ="17-- Geçen ay araba sürerken, yemek yerken ve ya sosyal bir aktivite esnasında ne kadar sıklıkla uyanık kalmak için zorlandınız? ",Numara ="17",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="Haftada 1'den az",Cevap3="Haftada 1-2 Kez",Cevap4="Haftada 3'den çok"},
                new Olcek { SoruPSQI = "18-Geçen ay bu durum işlerinizi yeteri kadar istekle yapmanızda ne derece problem oluşturdu? ", Numara = "18",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç problem oluşturmadı",Cevap2="Yalnızça çok az problem oluşturdu",Cevap3="Bir dereceye kadar problem oluşturdu",Cevap4="Çok büyük bir problem oluşturdu"},

                new Olcek {SoruPSQI = "19-Bir yatak partneriniz veya oda arkadaşınız var mı? ", Numara ="19",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Bir yatak partneri ya da oda arkadaşı yok",Cevap2="Diğer odada bir partneri veya oda arkadaşı var",Cevap3="Partneri aynı odada fakat aynı yatakta değil",Cevap4="Partner aynı yatakta"},

                new Olcek {SoruPSQI ="20-Gürültülü horlama ",Numara ="20",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},
                new Olcek {SoruPSQI = "21-Uykuda iken nefes alıp verme arasında uzun aralıklar ", Numara ="21",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},

                new Olcek {SoruPSQI ="22-Uyurken bacaklarda seyirme veya sıçrama ",Numara ="22",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},
                new Olcek { SoruPSQI = "23-Uyku esnasında uyumsuzluk ve şaşkınlık ", Numara = "23",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},

                new Olcek {SoruPSQI = "24-Uyurken olan diğer huzursuzluklarınız: ", Numara ="24",Soru="true",Soruters="false",Soruters2="false",Tptime="10",Cevap1="Hiç",Cevap2="1'den az",Cevap3="1-2 Kez",Cevap4="3'den çok"},


                

            };

            myRealList = myList;

            
            myListView.ItemsSource = myRealList;

          



        }

        private void btnpass_Clicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Perinatal Anksiyete Tarama Ölçeği", "Puanınız:" +Datacell.puan, "tamam");
         
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void CheckBox_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
        {

        }

        private void CheckBox_CheckedChanged_2(object sender, CheckedChangedEventArgs e)
        {
            
        }

        private void CheckBox_CheckedChanged_3(object sender, CheckedChangedEventArgs e)
        {
            myListView.ItemTemplate.Values.Count();
        }

        private void timepicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
   
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