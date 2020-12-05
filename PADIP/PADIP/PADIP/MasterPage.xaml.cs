using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PADIP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private async  void btnanne_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties[1000.ToString()] = 18;
            await Navigation.PushModalAsync(new Sosyodemografik());
        }

        private async void btngebeson_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties[1000.ToString()] = 27; 
            await Navigation.PushModalAsync(new Sosyodemografik());
        }

        private async void btngebeonce_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties[1000.ToString()] = 6;
            await Navigation.PushModalAsync(new Sosyodemografik());
        }

        private async void btnes_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties[1000.ToString()] = 14;
            await Navigation.PushModalAsync(new Sosyodemografik());
        }
    }
}