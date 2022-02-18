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
    public partial class Editor_Page : ContentPage
    {
        Editor editor;
        Label lbl;
        Button btn_tagasi;
        public Editor_Page()
        {
            //InitializeComponent();
            editor = new Editor
            {
                Placeholder="Sisesta siia teksti",
                PlaceholderColor=Color.Aqua,
                BackgroundColor=Color.Beige,
                TextColor=Color.Red
                //FontSize=40
            };
            editor.TextChanged += Editor_TextChanged;
            lbl = new Label
            {
                Text="Varsti näed, mittu A-d oli sisestatud",
                TextColor=Color.White,
                FontSize=40
            };
            btn_tagasi = new Button
            {
                Text="Tagasi",
                VerticalOptions=LayoutOptions.EndAndExpand
            };
            btn_tagasi.Clicked += Btn_tagasi_Clicked;
            StackLayout st = new StackLayout();
            st.BackgroundColor = Color.FromRgb(10, 50, 150);
            st.Children.Add(editor);
            st.Children.Add(lbl);
            st.Children.Add(btn_tagasi);
            Content = st;
        }

        private async void Btn_tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        int i = 0;
        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            editor.TextChanged -= Editor_TextChanged;
            char key = e.NewTextValue?.LastOrDefault() ?? ' ';
            if (key=='A')
            {
                i++;
                lbl.Text = key.ToString() + ": " + i.ToString();
            }
            editor.TextChanged += Editor_TextChanged;
        }
    }
}