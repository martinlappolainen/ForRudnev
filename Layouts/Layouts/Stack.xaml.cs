using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _ : ContentPage
    {
        public int tik = 0;
        

        public _()

        {
           
            InitializeComponent();

        }

      
        private void Button1_Clicked(object sender, EventArgs e)
        {
            tik = tik++;
            button1.Text = "Vajutatud" + tik + "Korda!";
        }

    }
}