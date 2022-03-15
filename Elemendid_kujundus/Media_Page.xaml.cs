using MediaManager;//
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Elemendid_kujundus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Media_Page : ContentPage
    {
        public IList<string> Mp3List => new[] 
        { "https://ia800806.us.archive.org/15/items/Mp3Playlist_555/AaronNeville-CrazyLove.mp3" };
              
        public Media_Page()
        {
            InitializeComponent();
        }               
        private async void btn_start_Clicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.Play(Mp3List); //1 variant
        }
        private async void btn_stop_Clicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.Stop();
        }
    }
}