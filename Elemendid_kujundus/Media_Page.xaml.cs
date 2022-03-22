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
        {
         "https://ia800806.us.archive.org/15/items/Mp3Playlist_555/AaronNeville-CrazyLove.mp3",
    "https://ia800605.us.archive.org/32/items/Mp3Playlist_555/CelineDion-IfICould.mp3",
    "https://ia800605.us.archive.org/32/items/Mp3Playlist_555/Daughtry-Homeacoustic.mp3",
    "https://storage.googleapis.com/uamp/The_Kyoto_Connection_-_Wake_Up/01_-_Intro_-_The_Way_Of_Waking_Up_feat_Alan_Watts.mp3",
    "https://aphid.fireside.fm/d/1437767933/02d84890-e58d-43eb-ab4c-26bcc8524289/d9b38b7f-5ede-4ca7-a5d6-a18d5605aba1.mp3" };
        
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
        private async void btn_paus_Clicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.Pause();
        }

        private void Volume_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            CrossMediaManager.Current.Volume.CurrentVolume = ((int)e.NewValue);
        }
        private async void Video_play_Clicked(object sender, EventArgs e)
        {
             await CrossMediaManager.Current.Play("http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4");//video
            
        }
    }
}