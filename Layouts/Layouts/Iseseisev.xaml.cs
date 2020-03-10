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
    public partial class Iseseisev : ContentPage
    {
        public Iseseisev()
        {
            var previousPageButton = new Button { Text = "Back", VerticalOptions = LayoutOptions.CenterAndExpand };
            previousPageButton.Clicked += OnPreviousPageButtonClicked;
            //InitializeComponent();
            AbsoluteLayout abs = new AbsoluteLayout();// Создание главного слоя

            BoxView osnova = new BoxView { BackgroundColor = Color.FromRgb(0, 0, 0) };// цветовой спектр
            BoxView redB = new BoxView { BackgroundColor = Color.FromRgb(255, 0, 0),CornerRadius= 70 };// Скругление углов
            BoxView yellowB = new BoxView { BackgroundColor = Color.FromRgb(255, 255, 0),CornerRadius=70 };
            BoxView greenB = new BoxView { BackgroundColor = Color.FromRgb(0, 255,0 ),CornerRadius=70 };

            AbsoluteLayout.SetLayoutBounds(osnova, new Rectangle(0.5, 0.3, 1000, 1000));// Создание прямоугольника
            AbsoluteLayout.SetLayoutFlags(osnova, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(redB, new Rectangle(0.5, 0.1, 150, 150));
            AbsoluteLayout.SetLayoutFlags(redB, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(greenB, new Rectangle(0.5, 0.9, 150, 150));
            AbsoluteLayout.SetLayoutFlags(greenB, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(yellowB, new Rectangle(0.5, 0.5, 150, 150));
            AbsoluteLayout.SetLayoutFlags(yellowB, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(osnova);// добавление элементов на слой
            abs.Children.Add(redB);
            abs.Children.Add(yellowB);
            abs.Children.Add(greenB);
            abs.Children.Add(previousPageButton);
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += (sender, e) => // условие
            {
                redB.IsVisible = false;// что происходит

            };
            redB.GestureRecognizers.Add(tap);// на что мы кликаем


            Content = abs;// какой слой отображаем
        }
        private async void OnPreviousPageButtonClicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }
    }
}