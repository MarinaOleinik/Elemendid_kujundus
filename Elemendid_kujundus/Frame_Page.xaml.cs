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
    public partial class Frame_Page : ContentPage
    {
        Frame frame;
        Label lbl;
        Grid grid;
        BoxView b;
        public Frame_Page()
        {
            //InitializeComponent();
            
            lbl = new Label
            {
                Text="Raami kujundus",
                FontSize=Device.GetNamedSize(NamedSize.Title,typeof(Label)),
                HorizontalOptions=LayoutOptions.Center
                
            };
            Title = lbl.Text;
            grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(2,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(2,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                }
            };
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    b = new BoxView { Color = Color.White };
                    grid.Children.Add(b, c, r);
                    TapGestureRecognizer tap = new TapGestureRecognizer();
                    tap.Tapped += Tap_Tapped;
                    b.GestureRecognizers.Add(tap);
                }
            }
            
            frame = new Frame
            {
                Content = grid,
                BorderColor=Color.Chartreuse,
                CornerRadius=30,
                VerticalOptions=LayoutOptions.FillAndExpand
            };
            StackLayout st = new StackLayout
            {
                
                Children = { lbl, frame }
            };
            Content = st;
            //Content=grid;
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            var b = (BoxView)sender;
            var r = Grid.GetRow(b);
            var c = Grid.GetColumn(b);
            b.Color = Color.Black;
        }
    }
}