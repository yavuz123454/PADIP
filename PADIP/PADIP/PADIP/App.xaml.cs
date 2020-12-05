using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PADIP
{
    public partial class App : Application
    {

        public const string isimsoyisim = "İsim";
        public const string yas = "25";
        private const string boy = "150";
        private const string kilo = "70";
        private const string kilogebe = "75";
        private const string egitim = "Lise";
        private const string calisma = "Çalışmıyor";
        private const string guvence = "Var";
        private const string birlikte = "Diğer";
        private const string evkisi = "3";
        private const string tgelir = "2000";
        private const string kacgebe = "4";
        private const string kaccocuk = "5";
        private const string odogum = "Evet1";
        private const string ococuk = "Evet2";
        private const string kurtaj = "Evet3";
        private const string khastalik = "Evet4";
        private const string khastalik2 = "Evet5";
        private const string ghafta2 = "30";
        private const string dateString = "5/1/2008 8:30:52 AM";
        private const string cinsiyet = "Erkek";
        private const string gebelikd = "Evet6";
        private const string gebelikt = "Evet7";
        private const string gebeliktakip = "Evet8";
        private const string gebeliktakipkac = "Evet9";
        private const string gebelikbebeksag = "Evet10";
        private const string gebelikbebekhas = "Evet11";
        private const string gebelikrahat = "Evet12";
        private const string gebelikrahatkac = "Evet13";
        private const string gebelikcinsiyet = "Evet14";
        private const string gebelikacinsiyet = "Evet15";
        private const string gebelikhasta = "Evet16";
        private const string gebelikhastadi = "Evet17";
        private const string gebelikpsihastami = "Evet18";
        private const string gebelikpsihasta = "Evet19";
        private const string gebelikpsihastadi = "Evet20";
        private const string gebelikpsitedavi = "Evet21";
        private const string gebelikpsisigara = "Evet22";
        private const string gebelikpsisigara2 = "Evet23";
        private const string gebelikpsibilgi = "Evet24";
        private const string gebelikpsibilgikim = "Evet25";
        private const string gebelikpsihareket = "Evet26";
        private const string gebelikpsihareket2 = "Evet27";
        private const string gebelikpsidans = "Evet28";
        private const string gebelikpsiacikhava = "Evet29";
        private const string gebelikpsisosyal = "Evet30";
        private const string gebelikpsisosyalsure = "Evet31";
        private const string gebelikpsisosyalbilgi = "Evet32";
        private const string gebelikpsidigerhastalik = "Evet33";
        private const string gebelikpsidigerhastalik2 = "Evet34";
        private const string bebekhastanesure = "Evet35";
        private const string esegitim = "Evet36";
        private const string escalisma = "Evet37";
        private const string eshastalik = "Evet38";
        private const string eshastalikolumsuz = "Evet39";
        private const string eshastalikruhsal = "Evet40";
        private const string eshastalikruhsalolumsuz = "Evet41";
        private const string essigara = "Evet42";
        private const string esalkol = "Evet43";
        private const string esmadde = "Evet44";
        private const string esiletisim = "Evet45";
        private const string esduygusal = "Evet46";
        private const string esfsiddet = "Evet47";
        private const string esdsiddet = "Evet48";
        private const string esesiddet = "Evet49";
        private const string gebelikpsikan = "Evet50";
        private const string gebelikpsikan2 = "Evet51";
        private const string gebelikpsikan3 = "Evet52";
        private const string gebelikpsisosyalsure2 = "Evet53";

        private const string gebecaka = "False21";
        private const string gebecakb = "False22";
        private const string gebecakc = "False23";
        private const string gebecakd = "False24";
        private const string gebecaka1 = "False25";
        private const string gebecakb1 = "False26";
        private const string gebecakc1 = "False27";
        private const string gebecakd1 = "False28";

        private const string gebecake = "False29";
        private const string gebecakf = "False30";
        private const string gebecakg = "False31";
        private const string gebecakh = "False32";
        private const string gebecaki = "False33";
        private const string gebecakj = "False34";
        private const string gebecakk = "False35";
        private const string gebecakl = "False36";

        private const string gebecakm = "False37";
        private const string gebecakn = "False38";
        private const string gebecako = "False39";
        private const string gebecakp = "False40";
        private const string gebecakr = "False41";
        private const string gebecaks = "False42";
        private const string gebecakt = "False43";
        private const string gebecaku = "False44";
        private const string gebecakv = "False45";

        private const string gebecaky = "False46";
        private const string gebecakz = "False47";
        private const string gebecake1 = "False48";

        private const string gebecakf1 = "False49";
        private const string gebecakg1 = "False50";
        private const string gebecakh1 = "False51";

        private const string gebecaki1 = "False52";
        private const string gebecakj1 = "False53";
        private const string gebecakk1 = "False54";
        private const string gebecakl1 = "False55";
        private const string gebecakm1 = "False56";
        private const string gebecakn1 = "False57";
        private const string gebecako1 = "False58";




        public string dogum = "01 / 02 / 2019";
        public string medeni = "Medeni Haliniz";
        public string yer = "Yaşadığınız Yer(İlçe)";
        public string hanekisi = "2";
        public string agelir = "3000";
        public string tgebelik = "0";
        public string sdogum = "200";
        public string ghafta = "20";
        public string rhastalik = "Evet";
        public string thastalik = "Evet";
        public string rghastalik = "Evet";
        public string tghastalik = "Evet";
        public float zaman = 12;
        public string sorusayisi = "1";


        public App()
        {
            InitializeComponent();
            Device.SetFlags(new String[] { "Expander_Experimental" });

            MainPage = new Anasayfa();
            //MainPage = new NavigationPage(new Sosyodemografik())
            //{
            //    BarBackgroundColor=Color.DeepPink
            //};





        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        public float Zaman { get { return zaman; } set { zaman = value; } }


        public string Title2 { get; set; }
        public string Yas2 { get; set; }
        public string Title
        {
            get
            {
                if (Properties.ContainsKey(isimsoyisim))
                    return  Properties[isimsoyisim].ToString();
                
                return "";
            }
            set
            {
                Properties[isimsoyisim] = value;
            }
        }

        public string Yas
        {
            get
            {
                if (Properties.ContainsKey(yas))
                    return Properties[yas].ToString();

                return "";
            }
            set
            {
                Properties[yas] = value;
            }
        }

        public string Boy
        {
            get
            {
                if (Properties.ContainsKey(boy))
                    return Properties[boy].ToString();

                return "";
            }
            set
            {
                Properties[boy] = value;
            }
        }

        public string Kilo
        {
            get
            {
                if (Properties.ContainsKey(kilo))
                    return Properties[kilo].ToString();

                return "";
            }
            set
            {
                Properties[kilo] = value;
            }
        }

        public string Egitim
        {
            get
            {
                if (Properties.ContainsKey(egitim))
                    return Properties[egitim].ToString();

                return "";
            }
            set
            {
                Properties[egitim] = value;
            }
        }


        public string Calisma
        {
            get
            {
                if (Properties.ContainsKey(calisma))
                    return Properties[calisma].ToString();

                return "";
            }
            set
            {
                Properties[calisma] = value;
            }
        }

        public string Kilogebe
        {
            get
            {
                if (Properties.ContainsKey(kilogebe))
                    return Properties[kilogebe].ToString();

                return "";
            }
            set
            {
                Properties[kilogebe] = value;
            }
        }
        public string Guvence
        {
            get
            {
                if (Properties.ContainsKey(guvence))
                    return Properties[guvence].ToString();

                return "";
            }
            set
            {
                Properties[guvence] = value;
            }
        }
        public string Birlikte
        {
            get
            {
                if (Properties.ContainsKey(birlikte))
                    return Properties[birlikte].ToString();

                return "";
            }
            set
            {
                Properties[birlikte] = value;
            }
        }

        public string Evkisi
        {
            get
            {
                if (Properties.ContainsKey(evkisi))
                    return Properties[evkisi].ToString();

                return "";
            }
            set
            {
                Properties[evkisi] = value;
            }
        }

        public string Tgelir
        {
            get
            {
                if (Properties.ContainsKey(tgelir))
                    return Properties[tgelir].ToString();

                return "";
            }
            set
            {
                Properties[tgelir] = value;
            }
        }
        public string Kacgebe
        {
            get
            {
                if (Properties.ContainsKey(kacgebe))
                    return Properties[kacgebe].ToString();

                return "";
            }
            set
            {
                Properties[kacgebe] = value;
            }
        }
        public string Kaccocuk
        {
            get
            {
                if (Properties.ContainsKey(kaccocuk))
                    return Properties[kaccocuk].ToString();

                return "";
            }
            set
            {
                Properties[kaccocuk] = value;
            }
        }
        public string Odogum
        {
            get
            {
                if (Properties.ContainsKey(odogum))
                    return Properties[odogum].ToString();

                return "";
            }
            set
            {
                Properties[odogum] = value;
            }
        }

        public string Ococuk
        {
            get
            {
                if (Properties.ContainsKey(ococuk))
                    return Properties[ococuk].ToString();

                return "";
            }
            set
            {
                Properties[ococuk] = value;
            }
        }

        public string Kurtaj
        {
            get
            {
                if (Properties.ContainsKey(kurtaj))
                    return Properties[kurtaj].ToString();

                return "";
            }
            set
            {
                Properties[kurtaj] = value;
            }
        }

        public string Khastalik
        {
            get
            {
                if (Properties.ContainsKey(khastalik))
                    return Properties[khastalik].ToString();

                return "";
            }
            set
            {
                Properties[khastalik] = value;
            }
        }

        public string Khastalik2
        {
            get
            {
                if (Properties.ContainsKey(khastalik2))
                    return Properties[khastalik2].ToString();

                return "";
            }
            set
            {
                Properties[khastalik2] = value;
            }
        }

        public string Ghafta2
        {
            get
            {
                if (Properties.ContainsKey(ghafta2))
                    return Properties[ghafta2].ToString();

                return "";
            }
            set
            {
                Properties[ghafta2] = value;
            }
        }

        public string Cinsiyet
        {
            get
            {
                if (Properties.ContainsKey(cinsiyet))
                    return Properties[cinsiyet].ToString();

                return "";
            }
            set
            {
                Properties[cinsiyet] = value;
            }
        }



        public string Dogum
        {
            get
            {
                if (Properties.ContainsKey(dateString))
                    return Properties[dateString].ToString();

                return "";
            }
            set
            {
                Properties[dateString] = value;
            }
        }
        public string Dogum2 {

            get
            {
                if (Properties.ContainsKey(dogum))
                    return Properties[dogum].ToString();

                return "";
            }
            set
            {
                Properties[dogum] = value;
            }



        }
        public string Yer
        {
            get
            {
                if (Properties.ContainsKey(yer))
                    return Properties[yer].ToString();

                return "";
            }
            set
            {
                Properties[yer] = value;
            }
        }

        public string Medeni
        {
            get
            {
                if (Properties.ContainsKey(medeni))
                    return Properties[medeni].ToString();

                return "";
            }
            set
            {
                Properties[medeni] = value;
            }
        }

        public string Hanekisi
        {
            get
            {
                if (Properties.ContainsKey(hanekisi))
                    return Properties[hanekisi].ToString();

                return "";
            }
            set
            {
                Properties[hanekisi] = value;
            }
        }
        public string Agelir
        {
            get
            {
                if (Properties.ContainsKey(agelir))
                    return Properties[agelir].ToString();

                return "";
            }
            set
            {
                Properties[agelir] = value;
            }
        }
        public string Tgebelik
        {
            get
            {
                if (Properties.ContainsKey(tgebelik))
                    return Properties[tgebelik].ToString();

                return "";
            }
            set
            {
                Properties[tgebelik] = value;
            }
        }
        public string Sdogum
        {
            get
            {
                if (Properties.ContainsKey(sdogum))
                    return Properties[sdogum].ToString();

                return "";
            }
            set
            {
                Properties[sdogum] = value;
            }
        }
        public string Ghafta
        {
            get
            {
                if (Properties.ContainsKey(ghafta))
                    return Properties[ghafta].ToString();

                return "";
            }
            set
            {
                Properties[ghafta] = value;
            }
        }
        public string Rhastalik
        {
            get
            {
                if (Properties.ContainsKey(rhastalik))
                    return Properties[rhastalik].ToString();

                return "";
            }
            set
            {
                Properties[rhastalik] = value;
            }
        }
        public string Thastalik
        {
            get
            {
                if (Properties.ContainsKey(thastalik))
                    return Properties[thastalik].ToString();

                return "";
            }
            set
            {
                Properties[thastalik] = value;
            }
        }
        public string Rghastalik
        {
            get
            {
                if (Properties.ContainsKey(rghastalik))
                    return Properties[rghastalik].ToString();

                return "";
            }
            set
            {
                Properties[rghastalik] = value;
            }
        }
        public string Tghastalik
        {
            get
            {
                if (Properties.ContainsKey(tghastalik))
                    return Properties[tghastalik].ToString();

                return "";
            }
            set
            {
                Properties[tghastalik] = value;
            }
        }

        public string Gebelikd
        {
            get
            {
                if (Properties.ContainsKey(gebelikd))
                    return Properties[gebelikd].ToString();

                return "";
            }
            set
            {
                Properties[gebelikd] = value;
            }
        }

        public string Gebelikt
        {
            get
            {
                if (Properties.ContainsKey(gebelikt))
                    return Properties[gebelikt].ToString();

                return "";
            }
            set
            {
                Properties[gebelikt] = value;
            }
        }
        public string Gebeliktakip
        {
            get
            {
                if (Properties.ContainsKey(gebeliktakip))
                    return Properties[gebeliktakip].ToString();

                return "";
            }
            set
            {
                Properties[gebeliktakip] = value;
            }
        }
        public string Gebeliktakipkac
        {
            get
            {
                if (Properties.ContainsKey(gebeliktakipkac))
                    return Properties[gebeliktakipkac].ToString();

                return "";
            }
            set
            {
                Properties[gebeliktakipkac] = value;
            }
        }

        public string Gebelikbebeksag
        {
            get
            {
                if (Properties.ContainsKey(gebelikbebeksag))
                    return Properties[gebelikbebeksag].ToString();

                return "";
            }
            set
            {
                Properties[gebelikbebeksag] = value;
            }
        }
        public string Gebelikbebekhas
        {
            get
            {
                if (Properties.ContainsKey(gebelikbebekhas))
                    return Properties[gebelikbebekhas].ToString();

                return "";
            }
            set
            {
                Properties[gebelikbebekhas] = value;
            }
        }

        public string Gebelikrahat
        {
            get
            {
                if (Properties.ContainsKey(gebelikrahat))
                    return Properties[gebelikrahat].ToString();

                return "";
            }
            set
            {
                Properties[gebelikrahat] = value;
            }
        }
        public string Gebelikrahatkac
        {
            get
            {
                if (Properties.ContainsKey(gebelikrahatkac))
                    return Properties[gebelikrahatkac].ToString();

                return "";
            }
            set
            {
                Properties[gebelikrahatkac] = value;
            }
        }

        public string Gebelikcinsiyet
        {
            get
            {
                if (Properties.ContainsKey(gebelikcinsiyet))
                    return Properties[gebelikcinsiyet].ToString();

                return "";
            }
            set
            {
                Properties[gebelikcinsiyet] = value;
            }
        }
        public string Gebelikacinsiyet
        {
            get
            {
                if (Properties.ContainsKey(gebelikacinsiyet))
                    return Properties[gebelikacinsiyet].ToString();

                return "";
            }
            set
            {
                Properties[gebelikacinsiyet] = value;
            }
        }

        public string Gebelikhasta
        {
            get
            {
                if (Properties.ContainsKey(gebelikhasta))
                    return Properties[gebelikhasta].ToString();

                return "";
            }
            set
            {
                Properties[gebelikhasta] = value;
            }
        }
        public string Gebelikhastadi
        {
            get
            {
                if (Properties.ContainsKey(gebelikhastadi))
                    return Properties[gebelikhastadi].ToString();

                return "";
            }
            set
            {
                Properties[gebelikhastadi] = value;
            }
        }

        public string Gebelikpsihastami
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsihastami))
                    return Properties[gebelikpsihastami].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsihastami] = value;
            }
        }

        public string Gebelikpsihasta
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsihasta))
                    return Properties[gebelikpsihasta].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsihasta] = value;
            }
        }

        public string Gebelikpsihastadi
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsihastadi))
                    return Properties[gebelikpsihastadi].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsihastadi] = value;
            }
        }

        public string Gebecaka
        {
            get
            {
                if (Properties.ContainsKey(gebecaka))
                    return Properties[gebecaka].ToString();

                return "";
            }
            set
            {
                Properties[gebecaka] = value;
            }
        }

        public string Gebecakb
        {
            get
            {
                if (Properties.ContainsKey(gebecakb))
                    return Properties[gebecakb].ToString();

                return "";
            }
            set
            {
                Properties[gebecakb] = value;
            }
        }

        public string Gebecakc
        {
            get
            {
                if (Properties.ContainsKey(gebecakc))
                    return Properties[gebecakc].ToString();

                return "";
            }
            set
            {
                Properties[gebecakc] = value;
            }
        }

        public string Gebecakd
        {
            get
            {
                if (Properties.ContainsKey(gebecakd))
                    return Properties[gebecakd].ToString();

                return "";
            }
            set
            {
                Properties[gebecakd] = value;
            }
        }


        public string Gebecaka1
        {
            get
            {
                if (Properties.ContainsKey(gebecaka1))
                    return Properties[gebecaka1].ToString();

                return "";
            }
            set
            {
                Properties[gebecaka1] = value;
            }
        }

        public string Gebecakb1
        {
            get
            {
                if (Properties.ContainsKey(gebecakb1))
                    return Properties[gebecakb1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakb1] = value;
            }
        }

        public string Gebecakc1
        {
            get
            {
                if (Properties.ContainsKey(gebecakc1))
                    return Properties[gebecakc1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakc1] = value;
            }
        }

        public string Gebecakd1
        {
            get
            {
                if (Properties.ContainsKey(gebecakd1))
                    return Properties[gebecakd1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakd1] = value;
            }
        }

        public string Gebelikpsitedavi
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsitedavi))
                    return Properties[gebelikpsitedavi].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsitedavi] = value;
            }
        }

        public string Gebelikpsisigara
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsisigara))
                    return Properties[gebelikpsisigara].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsisigara] = value;
            }
        }

        public string Gebelikpsisigara2
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsisigara2))
                    return Properties[gebelikpsisigara2].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsisigara2] = value;
            }
        }

        public string Gebelikpsibilgi
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsibilgi))
                    return Properties[gebelikpsibilgi].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsibilgi] = value;
            }
        }

        public string Gebelikpsibilgikim
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsibilgikim))
                    return Properties[gebelikpsibilgikim].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsibilgikim] = value;
            }
        }

        public string Gebelikpsihareket
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsihareket))
                    return Properties[gebelikpsihareket].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsihareket] = value;
            }
        }

        public string Gebelikpsihareket2
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsihareket2))
                    return Properties[gebelikpsihareket2].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsihareket2] = value;
            }
        }

        public string Gebelikpsidans
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsidans))
                    return Properties[gebelikpsidans].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsidans] = value;
            }
        }

        public string Gebelikpsiacikhava
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsiacikhava))
                    return Properties[gebelikpsiacikhava].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsiacikhava] = value;
            }
        }

        public string Gebelikpsisosyal
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsisosyal))
                    return Properties[gebelikpsisosyal].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsisosyal] = value;
            }
        }

        public string Gebelikpsisosyalsure
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsisosyalsure))
                    return Properties[gebelikpsisosyalsure].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsisosyalsure] = value;
            }
        }

        public string Gebelikpsisosyalbilgi
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsisosyalbilgi))
                    return Properties[gebelikpsisosyalbilgi].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsisosyalbilgi] = value;
            }
        }


        public string Gebecake
        {
            get
            {
                if (Properties.ContainsKey(gebecake))
                    return Properties[gebecake].ToString();

                return "";
            }
            set
            {
                Properties[gebecake] = value;
            }
        }

        public string Gebecakf
        {
            get
            {
                if (Properties.ContainsKey(gebecakf))
                    return Properties[gebecakf].ToString();

                return "";
            }
            set
            {
                Properties[gebecakf] = value;
            }
        }

        public string Gebecakg
        {
            get
            {
                if (Properties.ContainsKey(gebecakg))
                    return Properties[gebecakg].ToString();

                return "";
            }
            set
            {
                Properties[gebecakg] = value;
            }
        }

        public string Gebecakh
        {
            get
            {
                if (Properties.ContainsKey(gebecakh))
                    return Properties[gebecakh].ToString();

                return "";
            }
            set
            {
                Properties[gebecakh] = value;
            }
        }


        public string Gebecaki
        {
            get
            {
                if (Properties.ContainsKey(gebecaki))
                    return Properties[gebecaki].ToString();

                return "";
            }
            set
            {
                Properties[gebecaki] = value;
            }
        }

        public string Gebecakj
        {
            get
            {
                if (Properties.ContainsKey(gebecakj))
                    return Properties[gebecakj].ToString();

                return "";
            }
            set
            {
                Properties[gebecakj] = value;
            }
        }

        public string Gebecakk
        {
            get
            {
                if (Properties.ContainsKey(gebecakk))
                    return Properties[gebecakk].ToString();

                return "";
            }
            set
            {
                Properties[gebecakk] = value;
            }
        }

        public string Gebecakl
        {
            get
            {
                if (Properties.ContainsKey(gebecakl))
                    return Properties[gebecakl].ToString();

                return "";
            }
            set
            {
                Properties[gebecakl] = value;
            }
        }

        public string Gebelikpsidigerhastalik
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsidigerhastalik))
                    return Properties[gebelikpsidigerhastalik].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsidigerhastalik] = value;
            }
        }

        public string Gebelikpsidigerhastalik2
        {
            get
            {
                if (Properties.ContainsKey(gebelikpsidigerhastalik2))
                    return Properties[gebelikpsidigerhastalik2].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsidigerhastalik2] = value;
            }
        }

        public string Gebecakm
        {
            get
            {
                if (Properties.ContainsKey(gebecakm))
                    return Properties[gebecakm].ToString();

                return "";
            }
            set
            {
                Properties[gebecakm] = value;
            }
        }

        public string Gebecakn
        {
            get
            {
                if (Properties.ContainsKey(gebecakn))
                    return Properties[gebecakn].ToString();

                return "";
            }
            set
            {
                Properties[gebecakn] = value;
            }
        }

        public string Gebecako
        {
            get
            {
                if (Properties.ContainsKey(gebecako))
                    return Properties[gebecako].ToString();

                return "";
            }
            set
            {
                Properties[gebecako] = value;
            }
        }

        public string Gebecakp
        {
            get
            {
                if (Properties.ContainsKey(gebecakp))
                    return Properties[gebecakp].ToString();

                return "";
            }
            set
            {
                Properties[gebecakp] = value;
            }
        }


        public string Gebecakr
        {
            get
            {
                if (Properties.ContainsKey(gebecakr))
                    return Properties[gebecakr].ToString();

                return "";
            }
            set
            {
                Properties[gebecakr] = value;
            }
        }

        public string Gebecaks
        {
            get
            {
                if (Properties.ContainsKey(gebecaks))
                    return Properties[gebecaks].ToString();

                return "";
            }
            set
            {
                Properties[gebecaks] = value;
            }
        }

        public string Gebecakt
        {
            get
            {
                if (Properties.ContainsKey(gebecakt))
                    return Properties[gebecakt].ToString();

                return "";
            }
            set
            {
                Properties[gebecakt] = value;
            }
        }

        public string Gebecaku
        {
            get
            {
                if (Properties.ContainsKey(gebecaku))
                    return Properties[gebecaku].ToString();

                return "";
            }
            set
            {
                Properties[gebecaku] = value;
            }
        }
        public string Gebecakv
        {
            get
            {
                if (Properties.ContainsKey(gebecakv))
                    return Properties[gebecakv].ToString();

                return "";
            }
            set
            {
                Properties[gebecakv] = value;
            }
        }

        public string Gebecaky
        {
            get
            {
                if (Properties.ContainsKey(gebecaky))
                    return Properties[gebecaky].ToString();

                return "";
            }
            set
            {
                Properties[gebecaky] = value;
            }
        }

        public string Gebecakz
        {
            get
            {
                if (Properties.ContainsKey(gebecakz))
                    return Properties[gebecakz].ToString();

                return "";
            }
            set
            {
                Properties[gebecakz] = value;
            }
        }

        public string Gebecake1
        {
            get
            {
                if (Properties.ContainsKey(gebecake1))
                    return Properties[gebecake1].ToString();

                return "";
            }
            set
            {
                Properties[gebecake1] = value;
            }
        }

        public string Gebecakf1
        {
            get
            {
                if (Properties.ContainsKey(gebecakf1))
                    return Properties[gebecakf1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakf1] = value;
            }
        }

        public string Gebecakg1
        {
            get
            {
                if (Properties.ContainsKey(gebecakg1))
                    return Properties[gebecakg1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakg1] = value;
            }
        }

        public string Gebecakh1 { 

            get
            {
                if (Properties.ContainsKey(gebecakh1))
                    return Properties[gebecakh1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakh1] = value;
            }
        }

        public string Gebecaki1
        {
            get
            {
                if (Properties.ContainsKey(gebecaki1))
                    return Properties[gebecaki1].ToString();

                return "";
            }
            set
            {
                Properties[gebecaki1] = value;
            }
        }

        public string Gebecakj1
        {
            get
            {
                if (Properties.ContainsKey(gebecakj1))
                    return Properties[gebecakj1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakj1] = value;
            }
        }

        public string Gebecakk1
        {

            get
            {
                if (Properties.ContainsKey(gebecakk1))
                    return Properties[gebecakk1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakk1] = value;
            }
        }

        public string Gebecakl1
        {
            get
            {
                if (Properties.ContainsKey(gebecakl1))
                    return Properties[gebecakl1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakl1] = value;
            }
        }

        public string Gebecakm1
        {
            get
            {
                if (Properties.ContainsKey(gebecakm1))
                    return Properties[gebecakm1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakm1] = value;
            }
        }

        public string Gebecakn1
        {

            get
            {
                if (Properties.ContainsKey(gebecakn1))
                    return Properties[gebecakn1].ToString();

                return "";
            }
            set
            {
                Properties[gebecakn1] = value;
            }
        }

        public string Gebecako1
        {

            get
            {
                if (Properties.ContainsKey(gebecako1))
                    return Properties[gebecako1].ToString();

                return "";
            }
            set
            {
                Properties[gebecako1] = value;
            }
        }

        public string Bebekhastanesure
        {

            get
            {
                if (Properties.ContainsKey(bebekhastanesure))
                    return Properties[bebekhastanesure].ToString();

                return "";
            }
            set
            {
                Properties[bebekhastanesure] = value;
            }
        }
        public string Esegitim
        {

            get
            {
                if (Properties.ContainsKey(esegitim))
                    return Properties[esegitim].ToString();

                return "";
            }
            set
            {
                Properties[esegitim] = value;
            }
        }

        public string Escalisma
        {

            get
            {
                if (Properties.ContainsKey(escalisma))
                    return Properties[escalisma].ToString();

                return "";
            }
            set
            {
                Properties[escalisma] = value;
            }
        }
        public string Eshastalik
        {

            get
            {
                if (Properties.ContainsKey(eshastalik))
                    return Properties[eshastalik].ToString();

                return "";
            }
            set
            {
                Properties[eshastalik] = value;
            }
        }
        public string Eshastalikolumsuz
        {

            get
            {
                if (Properties.ContainsKey(eshastalikolumsuz))
                    return Properties[eshastalikolumsuz].ToString();

                return "";
            }
            set
            {
                Properties[eshastalikolumsuz] = value;
            }
        }
        public string Eshastalikruhsal
        {

            get
            {
                if (Properties.ContainsKey(eshastalikruhsal))
                    return Properties[eshastalikruhsal].ToString();

                return "";
            }
            set
            {
                Properties[eshastalikruhsal] = value;
            }
        }

        public string Eshastalikruhsalolumsuz
        {

            get
            {
                if (Properties.ContainsKey(eshastalikruhsalolumsuz))
                    return Properties[eshastalikruhsalolumsuz].ToString();

                return "";
            }
            set
            {
                Properties[eshastalikruhsalolumsuz] = value;
            }
        }

        public string Essigara
        {

            get
            {
                if (Properties.ContainsKey(essigara))
                    return Properties[essigara].ToString();

                return "";
            }
            set
            {
                Properties[essigara] = value;
            }
        }

        public string Esalkol
        {

            get
            {
                if (Properties.ContainsKey(esalkol))
                    return Properties[esalkol].ToString();

                return "";
            }
            set
            {
                Properties[esalkol] = value;
            }
        }

        public string Esmadde
        {

            get
            {
                if (Properties.ContainsKey(esmadde))
                    return Properties[esmadde].ToString();

                return "";
            }
            set
            {
                Properties[esmadde] = value;
            }
        }
        public string Esiletisim
        {

            get
            {
                if (Properties.ContainsKey(esiletisim))
                    return Properties[esiletisim].ToString();

                return "";
            }
            set
            {
                Properties[esiletisim] = value;
            }
        }

        public string Esduygusal
        {

            get
            {
                if (Properties.ContainsKey(esduygusal))
                    return Properties[esduygusal].ToString();

                return "";
            }
            set
            {
                Properties[esduygusal] = value;
            }
        }

        public string Esfsiddet
        {

            get
            {
                if (Properties.ContainsKey(esfsiddet))
                    return Properties[esfsiddet].ToString();

                return "";
            }
            set
            {
                Properties[esfsiddet] = value;
            }
        }

        public string Esdsiddet
        {

            get
            {
                if (Properties.ContainsKey(esdsiddet))
                    return Properties[esdsiddet].ToString();

                return "";
            }
            set
            {
                Properties[esdsiddet] = value;
            }
        }

        public string Esesiddet
        {

            get
            {
                if (Properties.ContainsKey(esesiddet))
                    return Properties[esesiddet].ToString();

                return "";
            }
            set
            {
                Properties[esesiddet] = value;
            }
        }

        public string Gebelikpsikan
        {

            get
            {
                if (Properties.ContainsKey(gebelikpsikan))
                    return Properties[gebelikpsikan].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsikan] = value;
            }
        }

        public string Gebelikpsikan2
        {

            get
            {
                if (Properties.ContainsKey(gebelikpsikan2))
                    return Properties[gebelikpsikan2].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsikan2] = value;
            }
        }

        public string Gebelikpsikan3
        {

            get
            {
                if (Properties.ContainsKey(gebelikpsikan3))
                    return Properties[gebelikpsikan3].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsikan3] = value;
            }
        }
        public string Gebelikpsisosyalsure2
        {

            get
            {
                if (Properties.ContainsKey(gebelikpsisosyalsure2))
                    return Properties[gebelikpsisosyalsure2].ToString();

                return "";
            }
            set
            {
                Properties[gebelikpsisosyalsure2] = value;
            }
        }

        public string Sorusayisi
        {

            get
            {
                if (Properties.ContainsKey(sorusayisi))
                    return Properties[sorusayisi].ToString();

                return "";
            }
            set
            {
                Properties[sorusayisi] = value;
            }
        }

    }
}
