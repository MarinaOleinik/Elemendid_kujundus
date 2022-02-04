using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid_kujundus
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button editor_btn = new Button 
            { 
                Text="Editor leht",
                TextColor=Color.Brown,
                BackgroundColor=Color.Aqua   
            };
            editor_btn.Clicked += Editor_btn_Clicked;
            StackLayout st = new StackLayout();
            st.BackgroundColor = Color.FromRgb(50, 50, 50);
            st.Children.Add(editor_btn);
            Content = st;

        }

        private async void Editor_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Editor_Page());
        }
    }
}
