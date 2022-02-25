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
        public Frame_Page()
        {
            lbl = new Label
            {
                Text="Raami kujundus",
                FontSize=Device.GetNamedSize(NamedSize.Title,typeof(Label))
            };
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
            grid.Children.Add(new BoxView { Color = Color.Red }, 0, 0);
            grid.Children.Add(new BoxView { Color = Color.Green }, 1, 0);
            grid.Children.Add(new BoxView { Color = Color.Blue }, 0, 1);
            grid.Children.Add(new BoxView { Color = Color.Yellow }, 1, 1);
            grid.Children.Add(new BoxView { Color = Color.MediumPurple }, 0, 2);
            grid.Children.Add(new BoxView { Color = Color.Beige }, 1, 2);
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
    }
}