using PADIP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PADIP.NavigationPagesFolder
{
    

    [XamlCompilation(XamlCompilationOptions.Compile)]

  
    public partial class Datacell : ViewCell
    {
        static TimeSpan  time1;
        static TimeSpan time2;
        static TimeSpan time3;
        static double tyatissuresi;
        static double yatissuresi;
        static double dalmasuresi;
        static double component2;
        static double component4;
        static int a = 0;
        static int b = 0;
       public static int puan = 0;
        int dene = 2;
        string dene2 = "04:12:04";
        public int Dene { get { return dene; } set { dene = value; } }
        private readonly IPageService _pageService;
        

        public Datacell(IPageService pageService)
        {
            _pageService = pageService;
        }

        public async Task<bool> DisplayAlert2(string title, string message, string ok, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
        }
        public Datacell()
        {
           
            InitializeComponent();
            //myentry.SetBinding(Entry.TextProperty, new Binding("Dene", source: this));
            //tpicker.SetBinding(TimePicker.TimeProperty,new Binding(""))
            
            //tpicker.Time = new TimeSpan(12, 2, 12);
            //TimeSpan time = new TimeSpan(10, 2, 12);
            //time = tpicker.Time - time;
            //string saat = tpicker.Time.ToString();
            ////Console.WriteLine(time);
        }
       
      
        private async void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (mybutton.Text=="5")
            {
              

                tyatissuresi = Convert.ToDouble(time3.Hours) + Convert.ToDouble(time3.Minutes / 60);
                component4 = yatissuresi * 100 / tyatissuresi;

              

                if (component4 > 85)
                {

                }
                if (component4 < 85 && component4 >= 75)
                {
                    puan = puan + 1;
                }
                if (component4 < 75 && component4 >= 65)
                {
                    puan = puan + 2;
                }

                if (component4 < 65)
                {
                    puan = puan + 3;
                }
            }
        }

        private async void CheckBox_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
        {
            puan = puan + 1;

            if (mybutton.Text == "5")
            {
               

                tyatissuresi = Convert.ToDouble(time3.Hours) + Convert.ToDouble(time3.Minutes / 60);
                component4 = yatissuresi * 100 / tyatissuresi;

            

                if (component4 > 85)
                {

                }
                if (component4 < 85 && component4 >= 75)
                {
                    puan = puan + 1;
                }
                if (component4 < 75 && component4 >= 65)
                {
                    puan = puan + 2;
                }

                if (component4 < 65)
                {
                    puan = puan + 3;
                }
            }
        }

        private async void CheckBox_CheckedChanged_2(object sender, CheckedChangedEventArgs e)
        {
            puan = puan + 2;

            if (mybutton.Text == "5")
            {
                
                tyatissuresi = Convert.ToDouble(time3.Hours) + Convert.ToDouble(time3.Minutes / 60);
                component4 = yatissuresi * 100 / tyatissuresi;

         

                if (component4 > 85)
                {

                }
                if (component4 < 85 && component4 >= 75)
                {
                    puan = puan + 1;
                }
                if (component4 < 75 && component4 >= 65)
                {
                    puan = puan + 2;
                }

                if (component4 < 65)
                {
                    puan = puan + 3;
                }
            }
        }

        private async void CheckBox_CheckedChanged_3(object sender, CheckedChangedEventArgs e)
        {
            puan = puan + 3;

            if (mybutton.Text == "5")
            {
               

                tyatissuresi = Convert.ToDouble(time3.Hours) + Convert.ToDouble(time3.Minutes / 60);
                component4 = yatissuresi * 100 / tyatissuresi;

             

                if (component4 > 85)
                {

                }
                if (component4 < 85 && component4 >= 75)
                {
                    puan = puan + 1;
                }
                if (component4 < 75 && component4 >= 65)
                {
                    puan = puan + 2;
                }

                if (component4 < 65)
                {
                    puan = puan + 3;
                }
            }
        }

        private async void  tpicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            if (e.PropertyName=="Time")
            {
                if (mybutton.Text=="1")
                {
                    time1 = tpicker.Time;
                   
                }


                if (mybutton.Text=="3")
                {
                    time2 = tpicker.Time;
                   
                    time3 = time2 - time1;
                  
                }
            }
         
           // Console.WriteLine(e.PropertyName);
           /*
            if (e.PropertyName == "Time"&&(a==0))
            {
                time1 = tpicker.Time;
                await DisplayAlert2(time1.ToString(), time1.ToString(), "tmm", "cancel");
               
             
            }

            if (e.PropertyName == "Time" && (a == 1 ))
            {

                time2 = tpicker.Time;
                await DisplayAlert2(time2.ToString(), time2.ToString(), "tmm", "cancel");
               
            }
            if (e.PropertyName == "Time")
            {
                
                a = a + 1;
                time3 = time2 - time1;
                await DisplayAlert2(a.ToString(), time1.ToString(), "tmm", "cancel");
                await DisplayAlert2(a.ToString(), time2.ToString(), "tmm", "cancel");
                await DisplayAlert2(a.ToString(), time3.ToString(), "tmm", "cancel");
            }
           */
           
        }

        private async void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //await DisplayAlert2("değişti", "değişti", "tmm", "tmm");
          
              
            // yatıssuresi = Convert.ToDouble (myentry.Text);
            if (mybutton.Text=="2")
            {
                try
                {
                    dalmasuresi = Convert.ToDouble(myentry.Text);
                    if (dalmasuresi<=15)
                    {

                    }
                    if (dalmasuresi > 15 && dalmasuresi <= 30)
                    {
                        puan = puan + 1;
                    }
                   
                    if (dalmasuresi > 30 && dalmasuresi <= 60 )
                    {
                        puan = puan + 2;
                    }
                    if (dalmasuresi > 60)
                    {
                        puan = puan + 3;
                    }
                    
                }
                catch (Exception)
                {

                    
                }

                

            }
            if (mybutton.Text == "4")
            {
                try
                {
                    yatissuresi = Convert.ToDouble(myentry.Text);


                    if (yatissuresi <= 5)
                    {
                        puan = puan + 3;
                    }
                    if (yatissuresi > 5 && yatissuresi <= 6)
                    {
                        puan = puan + 2;   
                    }

                    if (yatissuresi > 6 && yatissuresi <= 7)
                    {
                        puan = puan + 1;
                    }
                    if (yatissuresi > 7)
                    {
                        if (yatissuresi>=10)
                        {
                            puan = puan - 3;
                        }
                    }
                   
                }
                catch (Exception)
                {

                   
                }
              

            }

        }

        private async void myentry_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

          
            //await DisplayAlert2(e.PropertyName.ToString(), "sd", "sds", "dsad");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            await DisplayAlert2(dalmasuresi.ToString(), dalmasuresi.ToString(), "1", "2");
            await DisplayAlert2(yatissuresi.ToString(), yatissuresi.ToString(), "1", "2");
            
            tyatissuresi = Convert.ToDouble(time3.Hours)+ Convert.ToDouble(time3.Minutes/60);
            component4 = yatissuresi * 100 / tyatissuresi;

            await DisplayAlert2(component4.ToString(), tyatissuresi.ToString(), "tmm", "cancel");

            if (component4>85)
            {
               
            }
            if (component4 < 85 && component4 >= 75)
            {
                puan = puan + 1;
            }
            if (component4 < 75 && component4 >= 65)
            {
                puan = puan + 2;
            }

            if (component4 < 65)
            {
                puan = puan + 3;
            }
            // await DisplayAlert2(mybutton.Text, mybutton.Text, "1", "2");


            /*

            PSQI psqi = new PSQI();

            foreach (Olcek olcek in psqi.myRealList)
            {
                if (olcek.Numara=="2")
                {
                    await DisplayAlert2(olcek.Tptime, olcek.Tptime, "s", "s");
                }

               
            }

            */





        }
    }
}