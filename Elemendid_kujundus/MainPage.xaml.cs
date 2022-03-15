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
        Button editor_btn, timer_btn, box_btn, datepicker_btn,ss_btn, frame_btn;
        public MainPage()
        {
            datepicker_btn = new Button
            {
                Text = "Data/Time picker leht",
                TextColor = Color.Brown,
                BackgroundColor = Color.BlueViolet
            };
            datepicker_btn.Clicked += Start_Pages;
            ss_btn = new Button
            {
                Text = "Stepper/Slider leht",
                TextColor = Color.Brown,
                BackgroundColor = Color.BlueViolet
            };
            ss_btn.Clicked += Start_Pages;
            editor_btn = new Button 
            { 
                Text="Editor leht",
                TextColor=Color.Brown,
                BackgroundColor=Color.Aqua   
            };
            editor_btn.Clicked += Start_Pages;
            
            timer_btn = new Button
            {
                Text = "Timeri leht",
                TextColor = Color.Brown,
                BackgroundColor = Color.Aqua
            };
            timer_btn.Clicked += Start_Pages;
            box_btn = new Button
            {
                Text = "BoxView leht",
                TextColor = Color.Brown,
                BackgroundColor = Color.Aqua
            };
            box_btn.Clicked += Start_Pages;
            frame_btn = new Button
            {
                Text = "Frame/Grid leht",
                TextColor = Color.Brown,
                BackgroundColor = Color.Beige
            };
            frame_btn.Clicked += Start_Pages;
            StackLayout st = new StackLayout
            {
                Children = { editor_btn, timer_btn, box_btn, datepicker_btn,ss_btn, frame_btn }
            };
            st.BackgroundColor = Color.FromRgb(50, 50, 50);            
            Content = st;

        }

        private async void Start_Pages(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (sender==editor_btn)
            {
                await Navigation.PushAsync(new Editor_Page());
            }
            else if (sender==box_btn)
            {
                await Navigation.PushAsync(new BoxView_Page());
            }
            else if (sender==timer_btn)
            {
                await Navigation.PushAsync(new Timer_Page());
            }
            else if (sender == datepicker_btn)
            {
                await Navigation.PushAsync(new Date_Page());
            }
            else if (sender == ss_btn)
            {
                await Navigation.PushAsync(new SS_Page());
            }
            else if (sender == frame_btn)
            {
                await Navigation.PushAsync(new Frame_Page());
            }

        }

        
    }
}
