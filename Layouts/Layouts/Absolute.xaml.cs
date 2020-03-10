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
    public partial class Absolute : ContentPage
    {
        public Absolute()
        {
            //InitializeComponent();
            AbsoluteLayout abs = new AbsoluteLayout();
            abs.Children.Add(
                new Label { Text = "AbsoluteLayout kasutamine", FontSize = 30 },
                new Point (0,0)
                );
            abs.Children.Add(
                new BoxView { Color=Color.ForestGreen},
                new Rectangle(0, 100, 100, 100)
                );
            AbsoluteLayout abs1 = new AbsoluteLayout();
            BoxView redB = new BoxView { BackgroundColor = Color.FromRgb(255, 0, 0) };
            BoxView greenB = new BoxView { BackgroundColor = Color.FromRgb(0, 255, 0) };
            BoxView blueB = new BoxView { BackgroundColor = Color.FromRgb(0, 0, 255) };

            AbsoluteLayout.SetLayoutBounds(redB, new Rectangle(0.1, 0.3, 90, 90));
            AbsoluteLayout.SetLayoutFlags(redB, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(greenB, new Rectangle(0.6, 0.9, 100, 20));
            AbsoluteLayout.SetLayoutFlags(greenB, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(blueB, new Rectangle(0.4, 0.8, 90, 90));
            AbsoluteLayout.SetLayoutFlags(blueB, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(redB);
            abs.Children.Add(greenB);
            abs.Children.Add(blueB);

            Content = abs1;
        }
    }
}