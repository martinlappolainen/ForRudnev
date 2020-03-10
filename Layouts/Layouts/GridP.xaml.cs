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
    public partial class GridP : ContentPage
    {
        Button btn_newgrid;
        Grid grid;
        Random rnd;
        Label lbl;
        Switch sw;
        private int clik;
        public GridP()
        {
            clik = 0;
            var previousPageButton = new Button { Text = "Back", VerticalOptions = LayoutOptions.CenterAndExpand };
            previousPageButton.Clicked += OnPreviousPageButtonClicked;
            grid = new Grid
            {

                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1,GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1,GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1,GridUnitType.Star) }
                } 
            
            };

            rnd = new Random();
            int Number = rnd.Next( 1, 3);

            btn_newgrid = new Button { Text = "Обновить", TextColor = Color.Black };
            grid.Children.Add(btn_newgrid, 0, 3);
            btn_newgrid.Clicked += Btn_newgrid_Clicked; 
            lbl = new Label { Text = Convert.ToString(clik), Opacity = 50,FontSize=100};
            grid.Children.Add(lbl, 1, 3);
            sw = new Switch
            {
                IsToggled = true
            };
            sw.Toggled += Sw_toggled;
            grid.Children.Add(sw, 2, 3);
            Content = grid;
            grid.Children.Add(previousPageButton);
        }

        private void Sw_toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                btn_newgrid.IsEnabled = true;
            }
            else
            {
                btn_newgrid.IsEnabled = false;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid.Children.Add(new BoxView { Color = Color.Black }, i, j);
                }
            }
        }

        private void Btn_newgrid_Clicked(object sender, EventArgs e)
        {
            clik = clik+1;
            lbl.Text = Convert.ToString(clik);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid.Children.Add(new BoxView { Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)) }, i, j);
                }
            }
        }
        private async void OnPreviousPageButtonClicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }
    }
}