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
        public Editor_Page()
        {
            //InitializeComponent();
            Editor editor = new Editor
            {
                Placeholder="Sisesta siia teksti",
                PlaceholderColor=Color.Aqua,
                BackgroundColor=Color.Beige,
                TextColor=Color.Red
                //FontSize=40
            };
            StackLayout st = new StackLayout();
            st.BackgroundColor = Color.FromRgb(10, 50, 150);
            st.Children.Add(editor);
            Content = st;
        }
    }
}