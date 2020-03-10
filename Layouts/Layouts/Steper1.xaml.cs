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
    public partial class Steper1 : ContentPage
    {
        Image image;
        Stepper stepper;
        Slider slider;
        Label label;
        DatePicker datePicker;
        Label header2;
        Picker picker;
        Label header1;
        Label header;
        Grid grid;
        public Steper1()
        {
            grid = new Grid
            {
                RowDefinitions =
                {

                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }

                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
                
            };
            

            header = new Label
            {
                Text = "Stepper",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Start
            };

            stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 7,
                Increment = 1,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            };
            stepper.ValueChanged += OnStepperValueChanged;
            this.Content = new StackLayout { Children = { header, stepper } };

            header1 = new Label
            {
                Text = "Slider",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Start
            };

            slider = new Slider { Minimum = 0, Maximum = 3, Value = 0 };
            slider.ValueChanged += slider_ValueChanged;
            this.Content = new StackLayout { Children = { header1, slider } };
            header2 = new Label
            {
                Text = "Выберите Время года",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            picker = new Picker
            {
                Title = "Время года",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            picker.Items.Add("Зима");
            picker.Items.Add("Весна");
            picker.Items.Add("Лето");
            picker.Items.Add("Осень");
            picker.SelectedIndexChanged += picker_SelectedIndexChanged;
            this.Content = new StackLayout { Children = { header2, picker } };

            label = new Label { Text = "Выберите дату" };
            datePicker = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now.AddDays(5),
                MinimumDate = DateTime.Now.AddDays(-5)
            };
            datePicker.DateSelected += datePicker_DateSelected;
            StackLayout stack = new StackLayout { Children = { label, datePicker } };
            this.Content = stack;

            image = new Image { Source = "Winter.jpg" };
            this.Content = image;

            grid.Children.Add(stepper, 0, 0);
            grid.Children.Add(slider, 0, 1);
            grid.Children.Add(header, 0, 0);
            grid.Children.Add(header1, 0, 1);
            grid.Children.Add(header2, 0, 2);
            grid.Children.Add(picker, 0, 2);
            grid.Children.Add(label, 1, 1);
            grid.Children.Add(datePicker, 1, 0);
            grid.Children.Add(image, 1, 2);
            Content = grid;
        } private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
            {
            if (stepper.Value == 0)
            {
                BackgroundColor = default;
            }
            else if (stepper.Value == 1)
            {
                BackgroundColor =Color.Red;
            }
            else if (stepper.Value == 2)
            {
                BackgroundColor = Color.Orange;
            }
            else if (stepper.Value == 3)
            {
                BackgroundColor = Color.Yellow;
            }
            else if (stepper.Value == 4)
            {
                BackgroundColor = Color.Green;
            }
            else if (stepper.Value == 5)
            {
                BackgroundColor = Color.Blue;
            }
            else if (stepper.Value == 6)
            {
                BackgroundColor = Color.Violet;
            }
            else if (stepper.Value == 7)
            {
                BackgroundColor = Color.Indigo;
            }

        }
        void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if ((byte)slider.Value==0)
            {
                image.Source = "w.png";
            }
            else if ((byte)slider.Value == 1)
            {
                image.Source = "s.png";
            }
            else if ((byte)slider.Value == 2)
            {
                image.Source = "su.png";
            }
            else if ((byte)slider.Value == 3)
            {
                image.Source = "a.png";
            }
        }
        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (picker.Items[picker.SelectedIndex] == "Зима")
            {
                image.Source="w.png";
            }
            else if (picker.Items[picker.SelectedIndex] == "Весна")
            {
                image.Source = "s.png";
            }
            else if (picker.Items[picker.SelectedIndex] == "Лето")
            {
                image.Source = "su.png";
            }
            else if (picker.Items[picker.SelectedIndex] == "Осень")
            {
                image.Source = "a.png";
            }
        }
        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (datePicker.Date.DayOfWeek == DayOfWeek.Monday)
            {
                image.Source = "w.png";
            }
            else if (datePicker.Date.DayOfWeek == DayOfWeek.Tuesday)
            {
                image.Source = "s.png";
            }
            else if (datePicker.Date.DayOfWeek == DayOfWeek.Wednesday)
            {
                image.Source = "su.png";
            }
            else if (datePicker.Date.DayOfWeek == DayOfWeek.Thursday)
            {
                image.Source = "a.png";
            }
        }
    }   
}