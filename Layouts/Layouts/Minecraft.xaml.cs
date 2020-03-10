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
    public partial class Minecraft : ContentPage
    {
        public Minecraft()
        {
            var previousPageButton = new Button { Text = "Back", VerticalOptions = LayoutOptions.CenterAndExpand };
            previousPageButton.Clicked += OnPreviousPageButtonClicked;
            //InitializeComponent();
            AbsoluteLayout abs = new AbsoluteLayout();
            BoxView fon = new BoxView { BackgroundColor = Color.White};
            BoxView telo = new BoxView { BackgroundColor = Color.Gray};// цветовой спектр
            BoxView uhopravo = new BoxView { BackgroundColor = Color.Gray};
            BoxView uholevo = new BoxView { BackgroundColor = Color.Gray };
            BoxView glazlevo = new BoxView { BackgroundColor = Color.White};
            BoxView glazpravo = new BoxView { BackgroundColor = Color.White};
            BoxView lapaLevo = new BoxView { BackgroundColor = Color.Gray };
            BoxView lapaPravo = new BoxView { BackgroundColor = Color.Gray};
            BoxView nos = new BoxView { BackgroundColor = Color.Black};
            BoxView golova = new BoxView { BackgroundColor = Color.LightGray };
            BoxView zrachoklevo = new BoxView { BackgroundColor = Color.Black };
            BoxView zrachokpravo = new BoxView { BackgroundColor = Color.Black };
            Label lable = new Label();
            Button button4 = new Button();


            AbsoluteLayout.SetLayoutBounds(telo, new Rectangle(0.5, 0.5, 150,150 ));// Создание прямоугольника
            AbsoluteLayout.SetLayoutFlags(telo, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(golova, new Rectangle(0.5, 0.4, 170, 170));
            AbsoluteLayout.SetLayoutFlags(golova, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(lapaLevo, new Rectangle(0.33, 0.75, 30, 125));
            AbsoluteLayout.SetLayoutFlags(lapaLevo, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(lapaPravo, new Rectangle(0.67, 0.75, 30, 125));
            AbsoluteLayout.SetLayoutFlags(lapaPravo, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(uholevo, new Rectangle(0.33, 0.23, 50, 40));
            AbsoluteLayout.SetLayoutFlags(uholevo, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(uhopravo, new Rectangle(0.67, 0.23, 50, 40));
            AbsoluteLayout.SetLayoutFlags(uhopravo, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(glazlevo, new Rectangle(0.33, 0.4, 50, 30));
            AbsoluteLayout.SetLayoutFlags(glazlevo, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(glazpravo, new Rectangle(0.67, 0.4, 50, 30));
            AbsoluteLayout.SetLayoutFlags(glazpravo, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(nos, new Rectangle(0.5, 0.5, 50, 30));
            AbsoluteLayout.SetLayoutFlags(nos, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(zrachoklevo, new Rectangle(0.38, 0.4, 30, 30));
            AbsoluteLayout.SetLayoutFlags(zrachoklevo, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(zrachokpravo, new Rectangle(0.61, 0.4, 30, 30));
            AbsoluteLayout.SetLayoutFlags(zrachokpravo, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(lable, new Rectangle(0.5, 0.1, 80, 70));
            AbsoluteLayout.SetLayoutFlags(lable, AbsoluteLayoutFlags.PositionProportional);
            lable.FontSize = 20;

            abs.Children.Add(telo);// добавление элементов на слой
            abs.Children.Add(golova);
            abs.Children.Add(lapaLevo);
            abs.Children.Add(lapaPravo);
            abs.Children.Add(uholevo);
            abs.Children.Add(uhopravo);
            abs.Children.Add(glazlevo);
            abs.Children.Add(glazpravo);
            abs.Children.Add(nos);
            abs.Children.Add(zrachoklevo);
            abs.Children.Add(zrachokpravo);
            abs.Children.Add(lable);
            abs.Children.Add(previousPageButton);

            TapGestureRecognizer tel = new TapGestureRecognizer();
            tel.Tapped += (sender, e) => // условие
            {
                lable.Text = "";
                lable.Text = "Это тело";
            };
            telo.GestureRecognizers.Add(tel);// на что мы кликаем

            TapGestureRecognizer lapl = new TapGestureRecognizer();
            lapl.Tapped += (sender, e) => // условие
            {
                
                lable.Text = "Это  Левая Лапа";
            };
            lapaLevo.GestureRecognizers.Add(lapl);
            TapGestureRecognizer gol = new TapGestureRecognizer();
            gol.Tapped += (sender, e) => // условие
            {
                
                lable.Text = "Это Голова";
            };
            golova.GestureRecognizers.Add(gol);

            TapGestureRecognizer lapp = new TapGestureRecognizer();
            lapp.Tapped += (sender, e) => // условие
            {    
                lable.Text = "Это Правая лапа";
            };
            lapaPravo.GestureRecognizers.Add(lapp);

            TapGestureRecognizer uhl = new TapGestureRecognizer();
            uhl.Tapped += (sender, e) => // условие
            {      
                lable.Text = "Это Левое ухо";
            };
            uholevo.GestureRecognizers.Add(uhl);

            TapGestureRecognizer uhp = new TapGestureRecognizer();
            uhp.Tapped += (sender, e) => // условие
            {             
                lable.Text = "Это Правое ухо";
            };
            uhopravo.GestureRecognizers.Add(uhp);

            TapGestureRecognizer ns = new TapGestureRecognizer();
            ns.Tapped += (sender, e) => // условие
            {            
                lable.Text = "Это Нос";
            };
            nos.GestureRecognizers.Add(ns);

            TapGestureRecognizer glzp = new TapGestureRecognizer();
            glzp.Tapped += (sender, e) => // условие
            {              
                lable.Text = "Это Правый глаз";
            };
            glazpravo.GestureRecognizers.Add(glzp);
            TapGestureRecognizer glzl = new TapGestureRecognizer();
            glzl.Tapped += (sender, e) => // условие
            {
                lable.Text = "Это Левый глаз";
            };
            glazlevo.GestureRecognizers.Add(glzl);

            TapGestureRecognizer zrp = new TapGestureRecognizer();
            zrp.Tapped += (sender, e) => // условие
            { 
                lable.Text = "Это Правый зрачок";
            };
            zrachokpravo.GestureRecognizers.Add(zrp);

            TapGestureRecognizer zrl = new TapGestureRecognizer();
            zrl.Tapped += (sender, e) => // условие
            {
                lable.Text = "Это Левый зрачок";
            };
            zrachoklevo.GestureRecognizers.Add(zrl);

            Content = abs;// какой слой отображаем
        }
        private async void OnPreviousPageButtonClicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }
    }
}