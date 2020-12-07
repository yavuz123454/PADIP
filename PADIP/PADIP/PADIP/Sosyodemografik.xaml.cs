using PADIP.NavigationPagesFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PADIP;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PADIP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sosyodemografik : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
         
        int  sorusayisi2 = 1;
        string sorusayisi3 = "0";
        string sorusayisi4 = "1";
        int sorusayisi5 =1;
        public Sosyodemografik()
        {
            InitializeComponent();
            BindingContext = Application.Current;
            /*  if (Application.Current.Properties.ContainsKey(sorusayisi.ToString()))
              {
                  sorusayisi = Application.Current.Properties[sorusayisi.ToString()].ToString();
              }
              */
            gizle();
        }

        private async void  Button_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new PASS());
           // await firebaseHelper.AddPerson(entryad.Text, entryyas.Text,entryboy.Text,entrykilo.Text,entrykilogebe.Text,pickeregitim.SelectedItem.ToString());
          
           // await DisplayAlert("Success", "Person Added Successfully", "OK");
     
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
           
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (picker.SelectedIndex == 1)
            {
                takiplabel.IsVisible = false;
                entrylabel.IsVisible = false;
            }

            if (picker.SelectedIndex == 0)
            {
                takiplabel.IsVisible = true;
                entrylabel.IsVisible = true;
            }
        }

        private void pickergebesag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickergebesag.SelectedIndex == 1)
            {
                labelgebehast.IsVisible = false;
                pickergebehast.IsVisible = false;
            }
            if (pickergebesag.SelectedIndex == 0)
            {
                labelgebehast.IsVisible = true;
                pickergebehast.IsVisible = true;
            }
        }

        private void pickersorun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickersorun.SelectedIndex == 1)
            {
                rahatlabel.IsVisible = false;
                rahatentry.IsVisible = false;
            }
            if (pickersorun.SelectedIndex == 0)
            {
                rahatlabel.IsVisible = true;
                rahatentry.IsVisible = true;
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {


        }

        protected override void OnAppearing()
        {

        }

        private void pickerpsitani_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerpsitani.SelectedIndex == 1)
            {
                textgebepsihasta.IsVisible = false;
                pickergebepsihasta.IsVisible = false;
                labelgebelikpsihastadi.IsVisible = false;
                entrygebelikpsihastadi.IsVisible = false;
            }
            if (pickerpsitani.SelectedIndex == 0)
            {
                textgebepsihasta.IsVisible = true;
                pickergebepsihasta.IsVisible = true;
                labelgebelikpsihastadi.IsVisible = true;
                entrygebelikpsihastadi.IsVisible = true;
            }
        }

        private void checka_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //DisplayAlert(checka.IsChecked.ToString()+ checkb.IsChecked.ToString(), checkc.IsChecked.ToString()+ checkd.IsChecked.ToString(), "OK");
        }

        private void checkb_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            // DisplayAlert(checka.IsChecked.ToString() + checkb.IsChecked.ToString(), checkc.IsChecked.ToString() + checkd.IsChecked.ToString(), "OK");
        }

        private void checkc_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            // DisplayAlert(checka.IsChecked.ToString() + checkb.IsChecked.ToString(), checkc.IsChecked.ToString() + checkd.IsChecked.ToString(), "OK");
        }

        private void checkd_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //DisplayAlert(checka.IsChecked.ToString() + checkb.IsChecked.ToString(), checkc.IsChecked.ToString() + checkd.IsChecked.ToString(), "OK");
        }

        private void checka1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void checkb1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void checkc1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void checkd1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void pickerpsibirak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerpsibirak.SelectedIndex == 1)
            {
                textgebepsihasta2.IsVisible = false;
                pickergebepsihasta2.IsVisible = false;

            }
            if (pickerpsibirak.SelectedIndex == 0)
            {
                textgebepsihasta2.IsVisible = true;
                pickergebepsihasta2.IsVisible = true;
            }
        }

        private void pickerpsikan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Onceki_Clicked(object sender, EventArgs e)
        {
            if (sorusayisi2>1)
            {



                if (Application.Current.Properties.ContainsKey(1.ToString()))
                {
                    sorusayisi3 = Application.Current.Properties[1.ToString()].ToString();
                }
                sorusayisi2 = Convert.ToInt32(sorusayisi3);
                sorusayisi2 = sorusayisi2 - 1;
              
                Application.Current.Properties[1.ToString()] = sorusayisi2;
                //DisplayAlert(Application.Current.Properties[1.ToString()].ToString(), sorusayisi2.ToString(), "Ok");

                if (Application.Current.Properties.ContainsKey(1000.ToString()))
                {
                    sorusayisi4 = Application.Current.Properties[1000.ToString()].ToString();
                }
                sorusayisi5 = sorusayisi5 - 2;


                lblsorusayisi.Text = " Soru : " + sorusayisi5.ToString() + "/" + sorusayisi4;
                sorukontrol();
            }
        }

        private void Sonraki_Clicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey(1.ToString()))
            {
                sorusayisi3 = Application.Current.Properties[1.ToString()].ToString();
            }
            sorusayisi2 = Convert.ToInt32(sorusayisi3);
            sorusayisi2 = sorusayisi2 + 1;
            
            Application.Current.Properties[1.ToString()] = sorusayisi2;

            //DisplayAlert(Application.Current.Properties[1.ToString()].ToString(), sorusayisi2.ToString(), "Ok");
            if (Application.Current.Properties.ContainsKey(1000.ToString()))
            {
                sorusayisi4 = Application.Current.Properties[1000.ToString()].ToString();
            }
            
            lblsorusayisi.Text = " Soru : " + sorusayisi5.ToString() + "/" + sorusayisi4;
            sorukontrol();
        }
        private void sorukontrol()
        {
            lblad.IsVisible = false;
            entryad.IsVisible = false;
            lblyas.IsVisible = false;
            entryyas.IsVisible = false;
            lblyer.IsVisible = false;
            pickeryer.IsVisible = false;
            lblmedeni.IsVisible = false;
            pickermedeni.IsVisible = false;
            lblboy.IsVisible = false;
            entryboy.IsVisible = false;
            lblkilo.IsVisible = false;
            entrykilo.IsVisible = false;
            lblkilogebe.IsVisible = false;
            entrykilogebe.IsVisible = false;
            lblcalisma.IsVisible = false;
            pickercalisma.IsVisible = false;
            lblegitim.IsVisible = false;
            pickeregitim.IsVisible = false;
            lblguvence.IsVisible = false;
            pickerguvence.IsVisible = false;
            lblbirlikte.IsVisible = false;
            pickerbirlikte.IsVisible = false;
            lbltoplam.IsVisible = false;
            entrytoplam.IsVisible = false;
            lblgelir.IsVisible = false;
            pickergelir.IsVisible = false;
            lbltopgebe.IsVisible = false;
            entrytopgebe.IsVisible = false;
            lblkaccocuk.IsVisible = false;
            enrtykaccocuk.IsVisible = false;
            lbloludogum.IsVisible = false;
            pickeroludogum.IsVisible = false;
            lbloludogum2.IsVisible = false;
            pickeroludogum2.IsVisible = false;
            lbloludogum3.IsVisible = false;
            pickeroludogum3.IsVisible = false;
            lblkaccocuk.IsVisible = false;
            enrtykaccocuk.IsVisible = false;
            lbloludogum.IsVisible = false;
            pickeroludogum.IsVisible = false;
            lbloludogum2.IsVisible = false;
            pickeroludogum2.IsVisible = false;
            lbloludogum3.IsVisible = false;
            pickeroludogum3.IsVisible = false;
            lblkronik.IsVisible = false;
            pickerkronik.IsVisible = false;
            lblkronik2.IsVisible = false;
            pickerkronik2.IsVisible = false;
            lblgebehaf.IsVisible = false;
            entrygebehaf.IsVisible = false;
            lblbebecins.IsVisible = false;
            pickercins.IsVisible = false;
            lblgebelikd.IsVisible = false;
            pickergebelikd.IsVisible = false;
            lbltedavi.IsVisible = false;
            pickertedavi.IsVisible = false;
            lbltakip.IsVisible = false;
            picker.IsVisible = false;
            takiplabel.IsVisible = false;
            entrylabel.IsVisible = false;
            lblgebesag.IsVisible = false;
            pickergebesag.IsVisible = false;
            labelgebehast.IsVisible = false;
            pickergebehast.IsVisible = false;
            lblsorun.IsVisible = false;
            pickersorun.IsVisible = false;
            rahatlabel.IsVisible = false;
            rahatentry.IsVisible = false;
            lblcinsiyet.IsVisible = false;
            pickercinsiyet.IsVisible = false;
            lblcinsiyet2.IsVisible = false;
            pickercinsiyet2.IsVisible = false;
            lblgebelikhasta.IsVisible = false;
            pickergebelikhasta.IsVisible = false;
            labelgebelikhasta.IsVisible = false;
            entrygebelikhasta.IsVisible = false;
            lblpsitani.IsVisible = false;
            pickerpsitani.IsVisible = false;
            textgebepsihasta.IsVisible = false;
            pickergebepsihasta.IsVisible = false;
            labelgebelikpsihastadi.IsVisible = false;
            entrygebelikpsihastadi.IsVisible = false;
            textgebepsited.IsVisible = false;
            lbla.IsVisible = false;
            checka.IsVisible = false;
            lblb.IsVisible = false;
            checkb.IsVisible = false;
            lblc.IsVisible = false;
            checkc.IsVisible = false;
            lbld.IsVisible = false;
            checkd.IsVisible = false;
            textgebepsitee.IsVisible = false;
            lbla1.IsVisible = false;
            checka1.IsVisible = false;
            lblb1.IsVisible = false;
            checkb1.IsVisible = false;
            lblc1.IsVisible = false;
            checkc1.IsVisible = false;
            lbld1.IsVisible = false;
            checkd1.IsVisible = false;
            lblpsitedavi.IsVisible = false;
            pickerpsitedavi.IsVisible = false;
            lblpsibirak.IsVisible = false;
            pickerpsibirak.IsVisible = false;
            textgebepsihasta2.IsVisible = false;
            pickergebepsihasta2.IsVisible = false;
            lblpsisigara.IsVisible = false;
            pickergebelikpsisigara.IsVisible = false;
            lblpsisigara2.IsVisible = false;
            pickergebelikpsisigara2.IsVisible = false;
            lblgebelikpsibilgi.IsVisible = false;
            pickerpsibilgi.IsVisible = false;
            lblgebelikpsibilgikim.IsVisible = false;
            pickergebelikpsibilgikim.IsVisible = false;
            lblgebelikpsihareket.IsVisible = false;
            pickergebelikpsihareket.IsVisible = false;
            lblgebehareket.IsVisible = false;
            pickergebehareket.IsVisible = false;
            lblgebeegzersiz.IsVisible = false;
            pickergebeegzersiz.IsVisible = false;
            lblacikhava.IsVisible = false;
            pickeracikhava.IsVisible = false;
            lblpsisosyal.IsVisible = false;
            pickerpsisosyal.IsVisible = false;
            lblsosyalmedya.IsVisible = false;
            pickersosyalmedya.IsVisible = false;
            lblsosyal.IsVisible = false;
            pickersosyal.IsVisible = false;
            lblsosyalbilgi.IsVisible = false;
            pickersosyalbilgi.IsVisible = false;
            lblthastalik.IsVisible = false;
            lblgebecake.IsVisible = false;
            checke.IsVisible = false;
            lblgebecakf.IsVisible = false;
            checkf.IsVisible = false;
            lblgebecakg.IsVisible = false;
            checkg.IsVisible = false;
            lblgebecakh.IsVisible = false;
            checkh.IsVisible = false;
            lblgebecaki.IsVisible = false;
            checki.IsVisible = false;
            lblgebecakj.IsVisible = false;
            checkj.IsVisible = false;
            lblgebecakk.IsVisible = false;
            checkk.IsVisible = false;
            lblgebecakl.IsVisible = false;
            checkl.IsVisible = false;
            lbldigerhastalik.IsVisible = false;
            entrydigerhastalik.IsVisible = false;
            lbltani2.IsVisible = false;
            lblcakm.IsVisible = false;
            checkm.IsVisible = false;
            lblcakn.IsVisible = false;
            checkn.IsVisible = false;
            lblcako.IsVisible = false;
            checko.IsVisible = false;
            lbltani.IsVisible = false;
            lblcakv.IsVisible = false;
            cakv.IsVisible = false;
            lblcakp.IsVisible = false;
            cakp.IsVisible = false;
            lblcakr.IsVisible = false;
            cakr.IsVisible = false;
            lblcaks.IsVisible = false;
            caks.IsVisible = false;
            lblcakt.IsVisible = false;
            cakt.IsVisible = false;
            lblcaku.IsVisible = false;
            caku.IsVisible = false;
            lbldigerhastalik2.IsVisible = false;
            entrydigerhastalik2.IsVisible = false;
            lbldigerhastalik3.IsVisible = false;
            lblcaky.IsVisible = false;
            caky.IsVisible = false;
            lblcakz.IsVisible = false;
            cakz.IsVisible = false;
            lblcake1.IsVisible = false;
            cake1.IsVisible = false;
            lblterapist.IsVisible = false;
            lblcakf1.IsVisible = false;
            cakf1.IsVisible = false;
            lblcakg1.IsVisible = false;
            cakg1.IsVisible = false;
            lblcake12.IsVisible = false;
            cake12.IsVisible = false;
            lblsaglik2.IsVisible = false;
            lblcaki1.IsVisible = false;
            caki1.IsVisible = false;
            lblcakj1.IsVisible = false;
            cakij.IsVisible = false;
            lblcakk1.IsVisible = false;
            cakk1.IsVisible = false;
            lblcakl1.IsVisible = false;
            cakl1.IsVisible = false;
            lblcakm1.IsVisible = false;
            cakm1.IsVisible = false;
            lblcakn1.IsVisible = false;
            cakn1.IsVisible = false;
            lblcako1.IsVisible = false;
            cako1.IsVisible = false;
            lblsaglik.IsVisible = false;
            pickersaglik.IsVisible = false;
            lblhastane.IsVisible = false;
            entrybebekhastanesure.IsVisible = false;
            lblesyas.IsVisible = false;
            entryesyas.IsVisible = false;
            lblesegitim.IsVisible = false;
            pickeresegitim.IsVisible = false;
            lblescalisma.IsVisible = false;
            pickerrescalisma.IsVisible = false;
            lbleshasta.IsVisible = false;
            pickereshasta.IsVisible = false;
            lblolumsuz.IsVisible = false;
            pickerolumsuz.IsVisible = false;
            lblruhsal2.IsVisible = false;
            pickerruhsal2.IsVisible = false;
            lblruhsal.IsVisible = false;
            pickerruhsal.IsVisible = false;
            lblsigara.IsVisible = false;
            pickersigara.IsVisible = false;
            lblesalkol.IsVisible = false;
            pcikeresalkol.IsVisible = false;
            lblesmadde.IsVisible = false;
            pickeresmadde.IsVisible = false;
            lblesiletisim.IsVisible = false;
            entryesiletisim.IsVisible = false;
            lblesduygusal.IsVisible = false;
            entryesduygusal.IsVisible = false;
            lblessiddet.IsVisible = false;
            pickeressiddet.IsVisible = false;
            lblesduygusalsiddet.IsVisible = false;
            pickeresduygusalsiddet.IsVisible = false;
            lblesekonomiksiddet.IsVisible = false;
            pickeresekonomiksiddet.IsVisible = false;
            lblpsikan.IsVisible = false;
            pickerpsikan.IsVisible = false;
            textpsikan.IsVisible = false;
            pickerpsikan2.IsVisible = false;
            lblspikan2.IsVisible = false;
            entrykan.IsVisible = false;




            switch (sorusayisi2)
            {
           

                case 1:

                    lblad.IsVisible = true;
                    entryad.IsVisible = true;
                    sorusayisi5 = 2;
                    break;

                case 2:
                    lblyas.IsVisible = true;
                    entryyas.IsVisible = true;
                    sorusayisi5 = 3;
                    break;

                case 3:
                    lblyer.IsVisible = true;
                    pickeryer.IsVisible = true;
                    sorusayisi5 = 4;
                    break;


                case 4:
                   lblmedeni.IsVisible = true;
                    pickermedeni.IsVisible = true;
                    sorusayisi5 = 5;

                    break;
                case 5:
                    lblboy.IsVisible = true;
                    entryboy.IsVisible = true;
                    sorusayisi5 = 6;

                    break;

                case 6:
                    lblkilo.IsVisible = true;
                    entrykilo.IsVisible = true;
                    sorusayisi5 = 7;
                    break;

                case 7:
                    lblkilogebe.IsVisible = true;
                    entrykilogebe.IsVisible = true;
                    sorusayisi5 = 8;
                    break;

                case 8:
                   lblegitim.IsVisible = true;
                    pickeregitim.IsVisible = true;
                    sorusayisi5 = 9;

                    break;

                case 9:
                    lblcalisma.IsVisible = true;
                    pickercalisma.IsVisible = true;
                    sorusayisi5 = 10;
                    break;

                case 10:
                    lblguvence.IsVisible = true;
                    pickerguvence.IsVisible = true;
                    sorusayisi5 = 11;
                    break;

                case 11:
                    lblbirlikte.IsVisible = true;
                    pickerbirlikte.IsVisible = true;
                    sorusayisi5 = 12;
                    break;

                case 12:
                    lbltoplam.IsVisible = true;
                    entrytoplam.IsVisible = true;
                    sorusayisi5 = 13;
                    break;

                case 13:
                    lblgelir.IsVisible = true;
                    pickergelir.IsVisible = true;
                    sorusayisi5 = 14;
                    break;

                case 14:
                    lbltopgebe.IsVisible = true;
                    entrytopgebe.IsVisible = true;
                    sorusayisi5 = 15;
                    break;

                case 15:
                    lblkaccocuk.IsVisible = true;
                    enrtykaccocuk.IsVisible = true;
                    sorusayisi5 = 16;
                    break;

                case 16:
                    lbloludogum.IsVisible = true;
                    pickeroludogum.IsVisible = true;
                    sorusayisi5 = 17;
                    break;

                case 17:
                    lbloludogum2.IsVisible = true;
                    pickeroludogum2.IsVisible = true;
                    sorusayisi5 = 17;

                    break;

                case 18:
                    lbloludogum3.IsVisible = true;
                    pickeroludogum3.IsVisible = true;
                    sorusayisi5 = 17;
                    break;

                case 19:
                    lblkronik.IsVisible = true;
                    pickerkronik.IsVisible = true;
                    sorusayisi5 = 18;
                    break;

           

                case 24:
                    lblkronik2.IsVisible = true;
                    pickerkronik2.IsVisible = true;
                    sorusayisi5 = 18;
                    break;


                case 25:
                    lblgebehaf.IsVisible = true;
                    entrygebehaf.IsVisible = true;
                    sorusayisi5 = 19;
                    break;

                case 26:
                    lblbebecins.IsVisible = true;
                    pickercins.IsVisible = true;
                    sorusayisi5 = 20;
                    break;

                case 27:
                    lblgebelikd.IsVisible = true;
                    pickergebelikd.IsVisible = true;
                    sorusayisi5 = 21;
                    break;

                case 28:
                    lbltedavi.IsVisible = true;
                    pickertedavi.IsVisible = true;
                    sorusayisi5 = 22;
                    break;

                case 29:
                    lbltakip.IsVisible = true;
                    picker.IsVisible = true;
                    sorusayisi5 = 23;
                    break;

                case 30:
                    takiplabel.IsVisible = true;
                    entrylabel.IsVisible = true;
                    sorusayisi5 = 23;
                    break;

                case 31:
                    lblgebesag.IsVisible = true;
                    pickergebesag.IsVisible = true;
                    sorusayisi5 = 24;
                    break;

                case 32:
                    labelgebehast.IsVisible = true;
                    pickergebehast.IsVisible = true;
                    sorusayisi5 = 24;
                    break;

                case 33:
                    lblsorun.IsVisible = true;
                    pickersorun.IsVisible = true;
                    sorusayisi5 = 25;
                    break;

                case 34:
                    rahatlabel.IsVisible = true;
                    rahatentry.IsVisible = true;
                    sorusayisi5 = 25;
                    break;

                case 35:
                    lblcinsiyet.IsVisible = true;
                    pickercinsiyet.IsVisible = true;
                    sorusayisi5 = 26;
                    break;


                case 36:
                    lblcinsiyet2.IsVisible = true;
                    pickercinsiyet2.IsVisible = true;
                    sorusayisi5 = 27;
                    break;

                case 37:
                    lblgebelikhasta.IsVisible = true;
                    pickergebelikhasta.IsVisible = true;
                    sorusayisi5 = 28;
                    break;

                case 38:
                    labelgebelikhasta.IsVisible = true;
                    entrygebelikhasta.IsVisible = true;
                    sorusayisi5 = 28;
                    break;

                case 39:
                    lblpsitani.IsVisible = true;
                    pickerpsitani.IsVisible = true;
                    sorusayisi5 = 29;
                    break;

                case 40:
                    textgebepsihasta.IsVisible = true;
                    pickergebepsihasta.IsVisible = true;
                    sorusayisi5 = 29;
                    break;

                case 41:
                    labelgebelikpsihastadi.IsVisible = true;
                    entrygebelikpsihastadi.IsVisible = true;
                    sorusayisi5 = 29;
                    break;

                case 42:
                    textgebepsited.IsVisible = true;
                    lbla.IsVisible = true;
                    checka.IsVisible = true;
                    lblb.IsVisible = true;
                    checkb.IsVisible = true;
                    lblc.IsVisible = true;
                    checkc.IsVisible = true;
                    lbld.IsVisible = true;
                    checkd.IsVisible = true;
                    sorusayisi5 = 30;
                    break;

                case 43:
                    textgebepsitee.IsVisible = true;
                    lbla1.IsVisible = true;
                    checka1.IsVisible = true;
                    lblb1.IsVisible = true;
                    checkb1.IsVisible = true;
                    lblc1.IsVisible = true;
                    checkc1.IsVisible = true;
                    lbld1.IsVisible = true;
                    checkd1.IsVisible = true;
                    sorusayisi5 = 32;

                    break;

                case 44:
                    lblpsitedavi.IsVisible = true;
                    pickerpsitedavi.IsVisible = true;
                    sorusayisi5 = 31;
                    break;

                case 45:
                    lblpsibirak.IsVisible = true;
                    pickerpsibirak.IsVisible = true;
                    sorusayisi5 = 31;
                    break;

                case 46:
                    textgebepsihasta2.IsVisible = true;
                    pickergebepsihasta2.IsVisible = true;
                    sorusayisi5 = 33;
                    break;

                case 47:
                    lblpsisigara.IsVisible = true;
                    pickergebelikpsisigara.IsVisible = true;
                    sorusayisi5 = 34;
                    break;

                case 48:
                    lblpsisigara2.IsVisible = true;
                    pickergebelikpsisigara2.IsVisible = true;
                    sorusayisi5 = 35;
                    break;


                case 49:
                    lblgebelikpsibilgi.IsVisible = true;
                    pickerpsibilgi.IsVisible = true;
                    sorusayisi5 = 36;
                    break;

                case 50:
                    lblgebelikpsibilgikim.IsVisible = true;
                    pickergebelikpsibilgikim.IsVisible = true;
                    sorusayisi5 = 37;
                    break;

                case 51:
                    lblgebelikpsihareket.IsVisible = true;
                    pickergebelikpsihareket.IsVisible = true;
                    sorusayisi5 = 38;
                    break;

                case 52:
                    lblgebehareket.IsVisible = true;
                    pickergebehareket.IsVisible = true;
                    sorusayisi5 = 39;
                    break;

                case 53:
                    lblgebeegzersiz.IsVisible = true;
                    pickergebeegzersiz.IsVisible = true;
                    sorusayisi5 = 40;
                    break;

                case 54:
                    lblacikhava.IsVisible = true;
                    pickeracikhava.IsVisible = true;
                    sorusayisi5 = 41;
                    break;

                case 55:
                    lblpsisosyal.IsVisible = true;
                    pickerpsisosyal.IsVisible = true;
                    sorusayisi5 = 42;
                    break;

                case 56:
                    lblsosyalmedya.IsVisible = true;
                    pickersosyalmedya.IsVisible = true;
                    sorusayisi5 = 43;
                    break;

                case 57:
                    lblsosyal.IsVisible = true;
                    pickersosyal.IsVisible = true;
                    sorusayisi5 = 44;
                    break;

                case 58:
                    lblsosyalbilgi.IsVisible = true;
                    pickersosyalbilgi.IsVisible = true;
                    sorusayisi5 = 45;
                    break;

                case 59:
                    lblthastalik.IsVisible = true;
                    lblgebecake.IsVisible = true;
                    checke.IsVisible = true;
                    lblgebecakf.IsVisible = true;
                    checkf.IsVisible = true;
                    lblgebecakg.IsVisible = true;
                    checkg.IsVisible = true;
                    lblgebecakh.IsVisible = true;
                    checkh.IsVisible = true;
                    lblgebecaki.IsVisible = true;
                    checki.IsVisible = true;
                    lblgebecakj.IsVisible = true;
                    checkj.IsVisible = true;
                    lblgebecakk.IsVisible = true;
                    checkk.IsVisible = true;
                    lblgebecakl.IsVisible = true;
                    checkl.IsVisible = true;
                    sorusayisi5 = 46;

                    break;

                case 60:
                    lbldigerhastalik.IsVisible = true;
                    entrydigerhastalik.IsVisible = true;
                    sorusayisi5 = 46;
                    break;


                case 61:
                    lbltani2.IsVisible = true;
                    lblcakm.IsVisible = true;
                    checkm.IsVisible = true;
                    lblcakn.IsVisible = true;
                    checkn.IsVisible = true;
                    lblcako.IsVisible = true;
                    checko.IsVisible = true;
                    sorusayisi5 = 47;

                    break;

                case 62:
                    lbltani.IsVisible = true;
                    lblcakv.IsVisible = true;
                    cakv.IsVisible = true;
                    lblcakp.IsVisible = true;
                    cakp.IsVisible = true;
                    lblcakr.IsVisible = true;
                    cakr.IsVisible = true;
                    lblcaks.IsVisible = true;
                    caks.IsVisible = true;
                    lblcakt.IsVisible = true;
                    cakt.IsVisible = true;
                    lblcaku.IsVisible = true;
                    caku.IsVisible = true;
                    sorusayisi5 = 47;

                    break;

                case 63:
                    lbldigerhastalik2.IsVisible = true;
                    entrydigerhastalik2.IsVisible = true;
                    sorusayisi5 = 47;
                    break;

                case 64:
                    lbldigerhastalik3.IsVisible = true;
                    lblcaky.IsVisible = true;
                    caky.IsVisible = true;
                    lblcakz.IsVisible = true;
                    cakz.IsVisible = true;
                    lblcake1.IsVisible = true;
                    cake1.IsVisible = true;
                    sorusayisi5 = 48;
                    break;

                case 65:
                    lblterapist.IsVisible = true;
                    lblcakf1.IsVisible = true;
                    cakf1.IsVisible = true;
                    lblcakg1.IsVisible = true;
                    cakg1.IsVisible = true;
                    lblcake12.IsVisible = true;
                    cake12.IsVisible = true;
                    break;

                case 66:
                    lblsaglik2.IsVisible = true;
                    lblcaki1.IsVisible = true;
                    caki1.IsVisible = true;
                    lblcakj1.IsVisible = true;
                    cakij.IsVisible = true;
                    lblcakk1.IsVisible = true;
                    cakk1.IsVisible = true;
                    lblcakl1.IsVisible = true;
                    cakl1.IsVisible = true;
                    lblcakm1.IsVisible = true;
                    cakm1.IsVisible = true;
                    lblcakn1.IsVisible = true;
                    cakn1.IsVisible = true;
                    lblcako1.IsVisible = true;
                    cako1.IsVisible = true;
                    break;

                case 67:
                    lblsaglik.IsVisible = true;
                    pickersaglik.IsVisible = true;
                    break;
                case 68:
                    lblhastane.IsVisible = true;
                    entrybebekhastanesure.IsVisible = true;

                    break;
                case 69:
                    lblesyas.IsVisible = true;
                    entryesyas.IsVisible = true;

                    break;
                case 70:
                    lblesegitim.IsVisible = true;
                    pickeresegitim.IsVisible = true;

                    break;
                case 71:
                    lblescalisma.IsVisible = true;
                    pickerrescalisma.IsVisible = true;

                    break;
                case 72:
                    lbleshasta.IsVisible = true;
                    pickereshasta.IsVisible = true;

                    break;
                case 73:
                    lblolumsuz.IsVisible = true;
                    pickerolumsuz.IsVisible = true;

                    break;
                case 74:
                    lblruhsal2.IsVisible = true;
                    pickerruhsal2.IsVisible = true;

                    break;
                case 75:
                    lblruhsal.IsVisible = true;
                    pickerruhsal.IsVisible = true;

                    break;
                case 76:
                    lblsigara.IsVisible = true;
                    pickersigara.IsVisible = true;

                    break;
                case 77:
                    lblesalkol.IsVisible = true;
                    pcikeresalkol.IsVisible = true;

                    break;
                case 78:
                    lblesmadde.IsVisible = true;
                    pickeresmadde.IsVisible = true;

                    break;
                case 79:
                    lblesiletisim.IsVisible = true;
                    entryesiletisim.IsVisible = true;

                    break;
                case 80:
                    lblesduygusal.IsVisible = true;
                    entryesduygusal.IsVisible = true;

                    break;
                case 81:
                    lblessiddet.IsVisible = true;
                    pickeressiddet.IsVisible = true;

                    break;

                case 82:
                    lblesduygusalsiddet.IsVisible = true;
                    pickeresduygusalsiddet.IsVisible = true;

                    break;
                case 83:
                    lblesekonomiksiddet.IsVisible = true;
                    pickeresekonomiksiddet.IsVisible = true;

                    break;

                case 84:
                    lblpsikan.IsVisible = true;
                    pickerpsikan.IsVisible = true;

                    break;
                case 85:
                    textpsikan.IsVisible = true;
                    pickerpsikan2.IsVisible = true;

                    break;
                case 86:
                    lblspikan2.IsVisible = true;
                    entrykan.IsVisible = true;

                    break;
                


            }
        }

        private void gizle()
        {
            if (Application.Current.Properties.ContainsKey(1.ToString()))
            {
                sorusayisi3 = Application.Current.Properties[1.ToString()].ToString();
            }
            sorusayisi2 = Convert.ToInt32(sorusayisi3);
            if (sorusayisi2==0)
            {
                sorusayisi2 = 1;
                Application.Current.Properties[1.ToString()] = sorusayisi2;
            }

            if (Application.Current.Properties.ContainsKey(1000.ToString()))
            {
                sorusayisi4 = Application.Current.Properties[1000.ToString()].ToString();
            }

            lblsorusayisi.Text = " Soru : " + sorusayisi5.ToString() + "/"+sorusayisi4;
            sorukontrol();
            


        }
    }
}