using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid_kujundus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        BoxView red, yellow, green;
        bool on_off = false;
        Grid grid;
        Button btn;
        public Valgusfoor()
        {
            grid = new Grid
            {
                RowDefinitions =
                {

                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}   
                }
            };
            red = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 70,
                WidthRequest = 150,
                HeightRequest = 300,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            yellow = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 70,
                WidthRequest = 150,
                HeightRequest = 300,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            green = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 70,
                WidthRequest = 150,
                HeightRequest = 300,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            btn = new Button
            {
                Text = "Sisse",
                TextColor = Color.Brown,
                BackgroundColor = Color.BlueViolet
            };
            btn.Clicked += Btn_Clicked;
            grid.Children.Add(red, 0, 0);
            grid.Children.Add(yellow, 0, 1);
            grid.Children.Add(green, 0, 2);
            grid.Children.Add(btn, 0, 3);
            Content = grid;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            if (on_off)
            {
                on_off = false;
                btn.Text = "Sisse";
            }
            else
            {
                on_off = true;
                btn.Text = "Välja";
                Show();
            }
        }

        private async void Show()
        {
            while (on_off)
            {
                red.Color = Color.Red;
                await Task.Delay(1000);
                for (int i = 0; i < 2; i++)
                {
                    red.Color = Color.Red;
                    await Task.Delay(500);
                    red.Color = Color.Gray;
                    await Task.Delay(500);
                }
                if (on_off == false)
                {
                    break;
                }
                for (int i = 0; i < 3; i++)
                {
                    yellow.Color = Color.Yellow;
                    await Task.Delay(500);
                    yellow.Color = Color.Gray;
                    await Task.Delay(500);
                }
                if (on_off == false)
                {
                    break;
                }
                green.Color = Color.Green;
                await Task.Delay(2000);
                for (int i = 0; i < 2; i++)
                {
                    green.Color = Color.Green;
                    await Task.Delay(500);
                    green.Color = Color.Gray;
                    await Task.Delay(500);
                }
                if (on_off == false)
                {
                    break;
                }

            }
        }
    }
}