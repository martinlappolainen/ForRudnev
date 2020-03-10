using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Layouts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Steper1());
        }

        private async void Button1_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridP());
        }
        private async void Button2_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Iseseisev());

        }
        private async void Button3_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Minecraft());

        }
    }
}